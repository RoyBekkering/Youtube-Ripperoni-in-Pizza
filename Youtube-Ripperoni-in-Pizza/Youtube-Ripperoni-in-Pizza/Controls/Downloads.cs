using System;
using System.ComponentModel;
using System.Windows.Forms;
using Youtube_Ripperoni_in_Pizza.Models;
using YoutubeExtractor;

namespace Youtube_Ripperoni_in_Pizza.Controls
{
    public partial class Downloads : UserControl
    {
        private Timer timer;
        private string downloadPath;
        private BindingList<DownloadItem> dataSource;

        public Downloads()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Name";
            column.DataPropertyName = "ItemName";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView_Downloads.Columns.Add(column);

            DataGridViewProgressColumn column2 = new DataGridViewProgressColumn();
            column2.HeaderText = "Progress";
            column2.DataPropertyName = "Progress";
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView_Downloads.Columns.Add(column2);

            dataSource = new BindingList<DownloadItem>();
            this.dataGridView_Downloads.DataSource = dataSource;

            timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += (sender, args) => this.dataGridView_Downloads.Refresh();;
            timer.Start();
        }

        /// <summary>
        /// Tries to add the new item to the downloads.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="audioOnly"></param>
        public void AddDownload(VideoInfo info, bool audioOnly)
        {
            if(downloadPath == null) {
                MessageBox.Show("No download folder selected", "No download folder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach(DownloadItem item in dataSource) {
                if((item.VideoInfo.Title + item.VideoInfo.VideoExtension).Equals(info.Title + info.VideoExtension)) {
                    MessageBox.Show("Item is already being downloaded", "Already downloading", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            dataSource.Add(new DownloadItem(info, audioOnly, this.downloadPath));
        }

        /// <summary>
        /// Shows a dialog to the user to select the download folder.
        /// </summary>
        private void SelectDownloadFolder()
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if(result == DialogResult.OK) {
                downloadPath = folderBrowserDialog.SelectedPath;
                label_DownloadPath.Text = downloadPath;
            }
        }

        #region Events

        private void button_SelectFolder_Click(object sender, EventArgs e)
        {
            SelectDownloadFolder();
        }

        #endregion Events

    }
}