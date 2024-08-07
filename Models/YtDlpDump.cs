using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YtDlpGui.Models
{
    public static class YtDlpDump
    {
        public class DownloaderOptions
        {
            public int http_chunk_size { get; set; }
        }

        public class Format
        {
            public override string ToString()
            {
                if (resolution == "audio only")
                {
                    if (acodec == null)
                        acodec = "N/A";
                    return
                        $"{format_note} ({acodec.Split('.').First()}, abr: {abr.ToString().Replace(",", ".")}, {audio_ext})"
                            .Trim();
                }
                else
                {
                    if (vcodec == null)
                        vcodec = "N/A";
                    return
                        $"{resolution} ({vcodec.Split('.').First()}, vbr: {vbr.ToString().Replace(",", ".")}, {video_ext})"
                            .Trim();
                }
            }

            public string format_id { get; set; }
            public string format_note { get; set; }
            public string ext { get; set; }
            public string protocol { get; set; }
            public string acodec { get; set; }
            public string vcodec { get; set; }
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int rows { get; set; }
            public int columns { get; set; }
            public List<Fragment> fragments { get; set; }
            public string resolution { get; set; }
            public double aspect_ratio { get; set; }
            public string audio_ext { get; set; }
            public string video_ext { get; set; }
            public double vbr { get; set; }
            public double abr { get; set; }
            public string format { get; set; }
            public string manifest_url { get; set; }
            public string language { get; set; }
            public double quality { get; set; }
            public bool? has_drm { get; set; }
            public int? source_preference { get; set; }
            public int? asr { get; set; }
            public long filesize { get; set; }
            public int? audio_channels { get; set; }
            public double? tbr { get; set; }
            public long filesize_approx { get; set; }
            public int? language_preference { get; set; }
            public string container { get; set; }
            public DownloaderOptions downloader_options { get; set; }
            public string dynamic_range { get; set; }
        }

        public class Fragment
        {
            public string url { get; set; }
            public double duration { get; set; }
        }

        public class Heatmap
        {
            public double start_time { get; set; }
            public double end_time { get; set; }
            public double value { get; set; }
        }


        public class Dump
        {
            public string id { get; set; }
            public string title { get; set; }
            public List<Format> formats { get; set; }
            public List<Thumbnail> thumbnails { get; set; }
            public string thumbnail { get; set; }
            public string description { get; set; }
            public string channel_id { get; set; }
            public string channel_url { get; set; }
            public int duration { get; set; }
            public int view_count { get; set; }
            public int age_limit { get; set; }
            public string webpage_url { get; set; }
            public List<string> categories { get; set; }
            public List<string> tags { get; set; }
            public bool playable_in_embed { get; set; }
            public string live_status { get; set; }
            public List<string> _format_sort_fields { get; set; }
            public object automatic_captions { get; set; }
            public int comment_count { get; set; }
            public List<Heatmap> heatmap { get; set; }
            public int like_count { get; set; }
            public string channel { get; set; }
            public int channel_follower_count { get; set; }
            public bool channel_is_verified { get; set; }
            public string uploader { get; set; }
            public string uploader_id { get; set; }
            public string uploader_url { get; set; }
            public string upload_date { get; set; }
            public int timestamp { get; set; }
            public string availability { get; set; }
            public string webpage_url_basename { get; set; }
            public string webpage_url_domain { get; set; }
            public string extractor { get; set; }
            public string extractor_key { get; set; }
            public string display_id { get; set; }
            public string fulltitle { get; set; }
            public string duration_string { get; set; }
            public bool is_live { get; set; }
            public bool was_live { get; set; }
            public int epoch { get; set; }
            public string format { get; set; }
            public string format_id { get; set; }
            public string ext { get; set; }
            public string protocol { get; set; }
            public string language { get; set; }
            public string format_note { get; set; }
            public long filesize_approx { get; set; }
            public double tbr { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string resolution { get; set; }
            public string dynamic_range { get; set; }
            public string vcodec { get; set; }
            public double vbr { get; set; }
            public double aspect_ratio { get; set; }
            public string acodec { get; set; }
            public double abr { get; set; }
            public int asr { get; set; }
            public int audio_channels { get; set; }
            public string _type { get; set; }
            public Version _version { get; set; }
        }

        public class Thumbnail
        {
            public string url { get; set; }
            public int preference { get; set; }
            public string id { get; set; }
            public int? height { get; set; }
            public int? width { get; set; }
            public string resolution { get; set; }
        }

        public class Version
        {
            public string version { get; set; }
            public string release_git_head { get; set; }
            public string repository { get; set; }
        }
    }
}