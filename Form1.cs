using Newtonsoft.Json;
using System.Net;
using YtDlpGui.Models;

namespace YtDlpGui
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private Config Config = null;

        private Panel SelectedVideoFormat = null;
        private Panel SelectedAudioFormat = null;


        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            if (!File.Exists("config.json"))
                File.WriteAllText("config.json", JsonConvert.SerializeObject(new Config()
                {
                    SaveFolder =
                        Path.GetFullPath(Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads"),
                    Proxy = null,
                    ProxyEnabled = true,
                }, Formatting.Indented));

            Config = JsonConvert.DeserializeObject<Config>(File.ReadAllText("config.json"));
            textBox3.Text = Config.SaveFolder;
            textBox1.Text = Config.Proxy;
            checkBox1.Checked = Config.ProxyEnabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text.Trim()))
                return;

            if (textBox2.Text.StartsWith("https://"))
            {
                if (textBox2.Text.Contains("list="))
                {
                    MessageBox.Show("Playlists are not supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    textBox2.Text = "";
                    return;
                }

                textBox2.Enabled = false;
                button3.Enabled = false;
                pictureBox1.Visible = true;

                panel3.Controls.Clear();
                panel5.Controls.Clear();

                var task = new Task(() => { Download(); });
                task.Start();
            }
        }

        private void Download()
        {
            var formatButtons = new List<Button>();

            void ToggleInteraction(bool state)
            {
                textBox2.Enabled = state;
                button3.Enabled = state;
                pictureBox1.Visible = !state;
                foreach (var btn in formatButtons)
                    btn.Enabled = state;
            }

            var videos = new List<YtDlpDump.Dump>();

            videos = YtDlpApi.GetFormats(textBox2.Text, Config.ProxyEnabled ? Config.Proxy : null);

            if (videos.Count == 0)
            {
                ToggleInteraction(true);
                MessageBox.Show("Error during getting formats", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }

            videos = videos.Where(x => x.formats != null).ToList();

            var availableFormats = videos
                .First(x => x.formats.Count == videos.Max(x => x.formats.Count)).formats
                .Where(x => x.format_note !=
                    "storyboard" & x.format_note !=
                    "Default") /*.OrderBy(x => x.vbr == 0 ? -x.abr : -x.vbr)*/.Reverse().ToList();


            SelectedVideoFormat = null;
            SelectedAudioFormat = null;

            var groupBox1PosY = 2;
            var groupBox2PosY = 2;


            foreach (var format in availableFormats)
            {
                var isVideo = format.resolution != "audio only";

                var button = new Button();
                button.Dock = DockStyle.Right;
                button.FlatAppearance.BorderColor = Color.FromArgb(39, 39, 39);
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = Color.FromArgb(241, 241, 241);
                button.Location = new Point(153, 0);
                button.Size = new Size(24, 25);
                button.TabIndex = 6;
                button.Text = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String("4oaT"));
                button.UseVisualStyleBackColor = true;

                var label = new Label();
                label.FlatStyle = FlatStyle.Flat;
                label.ForeColor = Color.FromArgb(241, 241, 241);
                label.Location = new Point(-0, 1);
                label.Padding = new Padding(3, 3, 3, 3);
                label.Size = new Size(577, 25);
                label.Text = format.ToString();
                label.AutoSize = true;
                label.TextAlign = ContentAlignment.MiddleLeft;

                var panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(button);
                panel.Controls.Add(label);
                panel.Size = new Size(300, 27);

                panel.Click += onClick;
                label.Click += onClick;
                button.Click += onButtonClick;
                formatButtons.Add(button);

                panel.MouseEnter += onEnter;
                label.MouseEnter += onEnter;

                label.MouseLeave += onLeave;
                panel.MouseLeave += onLeave;

                panel.Tag = format.ToString();
                button.Tag = format.ToString();

                void onClick(object? sender, EventArgs e)
                {
                    if (isVideo)
                    {
                        if (SelectedVideoFormat != null)
                            SelectedVideoFormat.BackColor = Color.Transparent;
                        SelectedVideoFormat = panel;
                    }
                    else
                    {
                        if (SelectedAudioFormat != null)
                            SelectedAudioFormat.BackColor = Color.Transparent;
                        SelectedAudioFormat = panel;
                    }

                    panel.BackColor = Color.FromArgb(61, 61, 61);
                }

                void onEnter(object? sender, EventArgs e)
                {
                    if (SelectedAudioFormat != panel & SelectedVideoFormat != panel)
                    {
                        panel.BackColor = Color.FromArgb(34, 34, 34);
                        panel.ForeColor = Color.White;
                    }
                }

                void onLeave(object? sender, EventArgs e)
                {
                    if (SelectedAudioFormat != panel & SelectedVideoFormat != panel)
                    {
                        panel.BackColor = Color.Transparent;
                        panel.ForeColor = Color.FromArgb(241, 241, 241);
                    }
                }

                void onButtonClick(object? sender, EventArgs e)
                {
                    var senderButton = ((Button)sender);
                    var tag = senderButton.Tag;

                    if (!senderButton.Enabled)
                        return;

                    ToggleInteraction(false);

                    YtDlpDump.Format format = null;
                    string videoFormat = null, audioFormat = null;

                    if (tag == null)
                    {
                        videoFormat = videos.First().formats
                            .First(x => x.ToString() == SelectedVideoFormat.Tag.ToString()).format_id;
                        audioFormat = videos.First().formats
                            .First(x => x.ToString() == SelectedAudioFormat.Tag.ToString()).format_id;
                    }
                    else
                    {
                        format = availableFormats.FirstOrDefault(x => x.ToString() == tag.ToString());

                        if (isVideo)
                            videoFormat = format.format_id;
                        if (!isVideo)
                            audioFormat = format.format_id;
                    }


                    var task = new Task(() =>
                    {
                        YtDlpApi.DownloadFormats(textBox2.Text, Config.SaveFolder,
                            Config.ProxyEnabled ? Config.Proxy : null, videoFormat,
                            audioFormat);

                        ToggleInteraction(true);
                    });
                    task.Start();
                }

                button3_Click_Task = new Task(() => { onButtonClick(button3, null); });

                if (SelectedVideoFormat == null & isVideo)
                    onClick(null, null);
                if (SelectedAudioFormat == null & !isVideo)
                    onClick(null, null);

                if (format.resolution != "audio only")
                {
                    panel.Location = new Point(1, groupBox1PosY);
                    groupBox1PosY += panel.Size.Height;
                    Invoke(new Action(() => { panel3.Controls.Add(panel); }));
                }
                else
                {
                    panel.Location = new Point(1, groupBox2PosY);
                    groupBox2PosY += panel.Size.Height;
                    Invoke(new Action(() => { panel5.Controls.Add(panel); }));
                }
            }

            ToggleInteraction(true);


            ;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBox3.Text = Path.GetFullPath(fbd.SelectedPath);
                    Config.SaveFolder = textBox3.Text;
                    File.WriteAllText("config.json", JsonConvert.SerializeObject(Config, Formatting.Indented));
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
                Config.Proxy = null;
            else
                Config.Proxy = textBox1.Text.Trim();
            File.WriteAllText("config.json", JsonConvert.SerializeObject(Config, Formatting.Indented));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Config.ProxyEnabled = checkBox1.Checked;
            File.WriteAllText("config.json", JsonConvert.SerializeObject(Config, Formatting.Indented));
        }

        //fucking hell
        private Task button3_Click_Task = null;

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3_Click_Task != null)
                button3_Click_Task.Start();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            Task.Run(async () =>
            {
                var ytdlpBinUrl = "https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp.exe";
                using (var c = new WebClient())
                {
                    File.Delete(Program.YtDlpBinPath);
                    c.DownloadFileAsync(new Uri(ytdlpBinUrl), Program.YtDlpBinPath);
                    c.DownloadFileCompleted += (s, e) => { button3.Enabled = true; };
                }
            });

            MessageBox.Show("Yt-Dlp has been updated!", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}