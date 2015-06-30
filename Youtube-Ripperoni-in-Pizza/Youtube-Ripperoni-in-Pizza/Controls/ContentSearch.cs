using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Youtube_Ripperoni_in_Pizza.Models;
using Youtube_Ripperoni_in_Pizza.Models.Display;
using YoutubeAPI.Model;
using YoutubeExtractor;

namespace Youtube_Ripperoni_in_Pizza.Controls
{
    public partial class ContentSearch : UserControl
    {
        private List<Item> currentDataSource;
        private IEnumerable<VideoInfo> currentInfos;

        public Downloads DownloadControl { get; set; }

        public ContentSearch()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Name";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView_Content.Columns.Add(column);

            DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Description";
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView_Content.Columns.Add(column2);

            DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
            column3.HeaderText = "Channel";
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView_Content.Columns.Add(column3);
        }

        /// <summary>
        /// Searches for the given value. And starts the process of collecting and displaying all data.
        /// </summary>
        /// <param name="searchValue"></param>
        private void Search(string searchValue)
        {
            List<Item> results = YoutubeAPI.YoutubeAPI.Search(searchValue);
            currentDataSource = results;

            Populate(results);
        }

        /// <summary>
        /// Populates the datagridview.
        /// </summary>
        /// <param name="results"></param>
        private void Populate(List<Item> results)
        {
            List<VideoDisplay> dataSource = new List<VideoDisplay>();
            foreach(Item video in results) {
                dataSource.Add(new VideoDisplay() {
                    Title = video.snippet.title,
                    Description = video.snippet.description,
                    Channel = video.snippet.channelTitle
                });
            }

            dataGridView_Content.Columns.Clear();
            dataGridView_Content.DataSource = dataSource;
        }

        /// <summary>
        /// Adds the video corresponding to the given index to the downloads.
        /// </summary>
        /// <param name="index"></param>
        private void AddDownload()
        {
            if(currentInfos != null) {
                List<VideoInfo> videos;
                if(checkBox_OnlyAudio.Checked) {
                    videos = currentInfos.Where(v => v.CanExtractAudio && v.AudioType.ToString().Equals(comboBox_AudioType.SelectedItem.ToString().Replace(".", "")))
                        .OrderByDescending(info => info.AudioBitrate).ToList();
                }
                else {
                    videos = currentInfos.Where(v => v.Resolution.ToString().Equals(comboBox_Resolution.SelectedItem.ToString().Replace("p", "")) &&
                        v.VideoType.ToString().Equals(comboBox_VideoType.SelectedItem.ToString().Replace(".", ""))).ToList();
                }

                if(videos != null && videos.Count > 0) {
                    DownloadControl.AddDownload(videos[0], checkBox_OnlyAudio.Checked);
                }
                else {
                    MessageBox.Show("No video's found with the selected options", "No Videos Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Fetches all the info to populate the filtering-comboboxes.
        /// </summary>
        private void RunBackgroundWorker(int index)
        {
            EnableFilterOptions(false);
            BackgroundWorker bw = new BackgroundWorker();

            bw.DoWork += new DoWorkEventHandler(
            delegate(object sender, DoWorkEventArgs args)
            {
                Item item = currentDataSource[index];

                try {
                    IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls("https://www.youtube.com/watch?v=" + item.id.videoId);
                    currentInfos = videoInfos;

                    VideoInformation info = new VideoInformation() {
                        Resolutions = videoInfos.Select(v => v.Resolution).Distinct(),
                        VideoTypes = videoInfos.Select(v => v.VideoType).Distinct(),
                        AudioTypes = videoInfos.Select(v => v.AudioType).Distinct()
                    };
                    args.Result = info;
                }
                catch(Exception) { }
            });

            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
            delegate(object senden, RunWorkerCompletedEventArgs args)
            {
                if(args.Result != null && args.Result.GetType() == typeof(VideoInformation)) {
                    VideoInformation info = args.Result as VideoInformation;
                    try {
                        comboBox_Resolution.Items.Clear();
                        foreach(int resolution in info.Resolutions) {
                            comboBox_Resolution.Items.Add(resolution.ToString() + "p");
                        }

                        comboBox_VideoType.Items.Clear();
                        foreach(VideoType videoType in info.VideoTypes) {
                            comboBox_VideoType.Items.Add("." + videoType.ToString());
                        }

                        comboBox_AudioType.Items.Clear();
                        foreach(AudioType audioType in info.AudioTypes) {
                            comboBox_AudioType.Items.Add("." + audioType.ToString());
                        }
                    }
                    catch(Exception) { }
                }
                EnableFilterOptions(true);
            });

            bw.RunWorkerAsync();
        }

        /// <summary>
        /// Enables of disables the download filter options
        /// </summary>
        /// <param name="value"></param>
        private void EnableFilterOptions(bool value)
        {
            if(value) {
                bool checkedValue = checkBox_OnlyAudio.Checked;
                comboBox_Resolution.Enabled = !checkedValue;
                comboBox_VideoType.Enabled = !checkedValue;
                comboBox_AudioType.Enabled = checkedValue;
            }
            else {
                comboBox_Resolution.Enabled = false;
                comboBox_VideoType.Enabled = false;
                comboBox_AudioType.Enabled = false;
            }

            checkBox_OnlyAudio.Enabled = value;
            button_AddDownload.Enabled = value;
            tableLayout_Filters.UseWaitCursor = !value;
        }

        #region Events

        private void button_Search_Click(object sender, System.EventArgs e)
        {
            if(!textBox_Search.Text.Equals(textBox_Search.Placeholder) && textBox_Search.Text.Length > 0) {
                Search(textBox_Search.Text);
            }
        }

        private void button_AddDownload_Click(object sender, EventArgs e)
        {
            if(dataGridView_Content.SelectedRows[0].Index >= 0) {
                AddDownload();
            }
        }

        private void dataGridView_Content_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) {
                RunBackgroundWorker(e.RowIndex);
            }
        }

        private void checkBox_OnlyAudio_CheckedChanged(object sender, EventArgs e)
        {
            bool value = (sender as CheckBox).Checked;

            comboBox_Resolution.Enabled = !value;
            comboBox_VideoType.Enabled = !value;
            comboBox_AudioType.Enabled = value;
        }

        private void textBox_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter) {
                button_Search_Click(null, null);
            }
        }

        #endregion Events
    }
}