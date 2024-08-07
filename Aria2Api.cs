using System.Diagnostics;

namespace YtDlpGui
{
    public static class Aria2Api
    {
        public static void SimpleDownload(string url, string downloadFolder, string filename, string proxyStr)
        {
            var filePath = Path.GetFullPath(Path.Combine(downloadFolder, filename));

            var runCommand =
                $"--max-tries=100 --retry-wait=2 -s 64 -x 64 -j 64 -k 1M --file-allocation=none {(proxyStr != null ? $"--all-proxy \"{proxyStr}\"" : null)} -o \"{filename}\" \"$url$\""
                    .Replace("$url$", url);

            var process = new Process
            {
                StartInfo =
                {
                    FileName = Path.GetFullPath(Program.Aria2BinPath),
                    Arguments = runCommand,
                    WorkingDirectory = downloadFolder,
                    UseShellExecute = false,
                    CreateNoWindow = !Program.Debug
                }
            };

            process.Start();
            process.WaitForExit();
        }

        public static void MultipleDownload(string urlListFile, string downloadFolder, string proxyStr)
        {
            var runCommand =
                $"--max-tries=100 --retry-wait=5 -s 4 -x 4 -j 16 -k 1M --file-allocation=none -i \"{urlListFile}\" {(proxyStr != null ? $"--all-proxy \"{proxyStr}\"" : null)} -d \"{downloadFolder}\"";

            var process = new Process
            {
                StartInfo =
                {
                    FileName = Path.GetFullPath(Program.Aria2BinPath),
                    Arguments = runCommand,
                    WorkingDirectory = downloadFolder,
                    UseShellExecute = false,
                    CreateNoWindow = !Program.Debug
                }
            };

            process.Start();
            process.WaitForExit();
        }
    }
}