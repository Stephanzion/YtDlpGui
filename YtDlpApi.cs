using Newtonsoft.Json;
using System.Diagnostics;
using YtDlpGui.Models;

namespace YtDlpGui
{
    public static class YtDlpApi
    {
        public static List<YtDlpDump.Dump> GetFormats(string url, string proxyStr)
        {
            Directory.CreateDirectory("cache");

            foreach (var file in Directory.GetFiles("cache"))
                File.Delete(file);
            foreach (var dir in Directory.GetDirectories("cache"))
                File.Delete(dir);

            var infoFolder = Path.GetFullPath("cache");

            var runCommand =
                $"--skip-download --write-info-json {(proxyStr != null ? $"--proxy \"{proxyStr}\"" : null)} --output \"%(id)s.%(ext)s\" \"$url$\""
                    .Replace("$url$", url);

            var process = new Process
            {
                StartInfo =
                {
                    FileName = Path.GetFullPath(Program.YtDlpBinPath),
                    Arguments = runCommand,
                    WorkingDirectory = infoFolder,
                    UseShellExecute = false,
                    CreateNoWindow = !Program.Debug
                }
            };

            process.Start();
            process.WaitForExit();

            var list = new List<YtDlpDump.Dump>();

            foreach (var file in Directory.GetFiles(infoFolder, "*.json"))
            {
                try
                {
                    list.Add(JsonConvert.DeserializeObject<YtDlpDump.Dump>(File.ReadAllText(file)));
                }
                catch
                {
                }

                break;
            }

            return list;
        }

        public static void DownloadFormats(string url, string downloadDirectory, string proxyStr, string videoFormatId,
            string audioFormatId)
        {
            string formatString = null;

            if (videoFormatId != null & audioFormatId != null)
                formatString = $"{videoFormatId}+{audioFormatId}";
            else
            {
                var oneFormat = videoFormatId != null ? videoFormatId : audioFormatId;
                formatString = $"{oneFormat}";
            }

            var runCommand =
                $"-f \"{formatString}\" --no-mtime --downloader \"{Path.GetFullPath(Program.Aria2BinPath)}\" --downloader-args \"-s 64 -x 64 -j 64 -k 1M --file-allocation=none {(proxyStr != null ? $"--all-proxy '{proxyStr}'" : null)}\" {(proxyStr != null ? $"--proxy \"{proxyStr}\"" : null)} -o \"%(title)s_%(epoch)s.%(ext)s\" \"$url$\""
                    .Replace("$url$", url);

            var process = new Process
            {
                StartInfo =
                {
                    FileName = Path.GetFullPath(Program.YtDlpBinPath),
                    Arguments = runCommand,
                    WorkingDirectory = downloadDirectory,
                    UseShellExecute = false,
                    CreateNoWindow = !Program.Debug
                }
            };

            process.Start();
            process.WaitForExit();
        }
    }
}