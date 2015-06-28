namespace Youtube_Ripperoni_in_Pizza
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitView_Main = new System.Windows.Forms.SplitContainer();
            this.tableLayout_Content = new System.Windows.Forms.TableLayoutPanel();
            this.SearchTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button_Search = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Downloads = new System.Windows.Forms.GroupBox();
            this.tableLayout_Downloads = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Filters = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_Audio = new System.Windows.Forms.CheckBox();
            this.comboBox_Resolution = new System.Windows.Forms.ComboBox();
            this.comboBox_AudioBitRate = new System.Windows.Forms.ComboBox();
            this.comboBox_AudioType = new System.Windows.Forms.ComboBox();
            this.tableLayout_Options = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_DownloadQueue = new System.Windows.Forms.CheckBox();
            this.checkBox_CloseAfterLast = new System.Windows.Forms.CheckBox();
            this.comboBox_VideoType = new System.Windows.Forms.ComboBox();
            this.dataGridView_Content = new System.Windows.Forms.DataGridView();
            this.dataGridView_Downloads = new System.Windows.Forms.DataGridView();
            this.textBox_Search = new Youtube_Ripperoni_in_Pizza.Controls.TextBoxPlaceHolder();
            ((System.ComponentModel.ISupportInitialize)(this.splitView_Main)).BeginInit();
            this.splitView_Main.Panel1.SuspendLayout();
            this.splitView_Main.Panel2.SuspendLayout();
            this.splitView_Main.SuspendLayout();
            this.tableLayout_Content.SuspendLayout();
            this.SearchTableLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_Downloads.SuspendLayout();
            this.tableLayout_Downloads.SuspendLayout();
            this.tableLayout_Filters.SuspendLayout();
            this.tableLayout_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Content)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Downloads)).BeginInit();
            this.SuspendLayout();
            // 
            // splitView_Main
            // 
            this.splitView_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitView_Main.Location = new System.Drawing.Point(0, 0);
            this.splitView_Main.Name = "splitView_Main";
            // 
            // splitView_Main.Panel1
            // 
            this.splitView_Main.Panel1.Controls.Add(this.tableLayout_Content);
            this.splitView_Main.Panel1MinSize = 200;
            // 
            // splitView_Main.Panel2
            // 
            this.splitView_Main.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitView_Main.Panel2MinSize = 200;
            this.splitView_Main.Size = new System.Drawing.Size(984, 561);
            this.splitView_Main.SplitterDistance = 491;
            this.splitView_Main.TabIndex = 0;
            // 
            // tableLayout_Content
            // 
            this.tableLayout_Content.ColumnCount = 1;
            this.tableLayout_Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Content.Controls.Add(this.tableLayout_Filters, 0, 2);
            this.tableLayout_Content.Controls.Add(this.SearchTableLayout, 0, 0);
            this.tableLayout_Content.Controls.Add(this.dataGridView_Content, 0, 1);
            this.tableLayout_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Content.Location = new System.Drawing.Point(0, 0);
            this.tableLayout_Content.Name = "tableLayout_Content";
            this.tableLayout_Content.RowCount = 3;
            this.tableLayout_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayout_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayout_Content.Size = new System.Drawing.Size(491, 561);
            this.tableLayout_Content.TabIndex = 0;
            // 
            // SearchTableLayout
            // 
            this.SearchTableLayout.ColumnCount = 2;
            this.SearchTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SearchTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.SearchTableLayout.Controls.Add(this.button_Search, 1, 0);
            this.SearchTableLayout.Controls.Add(this.textBox_Search, 0, 0);
            this.SearchTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTableLayout.Location = new System.Drawing.Point(3, 3);
            this.SearchTableLayout.Name = "SearchTableLayout";
            this.SearchTableLayout.RowCount = 1;
            this.SearchTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.SearchTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.SearchTableLayout.Size = new System.Drawing.Size(485, 29);
            this.SearchTableLayout.TabIndex = 2;
            // 
            // button_Search
            // 
            this.button_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Search.Location = new System.Drawing.Point(376, 3);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(106, 23);
            this.button_Search.TabIndex = 1;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Downloads, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox_Downloads
            // 
            this.groupBox_Downloads.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Downloads.Controls.Add(this.tableLayout_Downloads);
            this.groupBox_Downloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Downloads.Location = new System.Drawing.Point(0, 3);
            this.groupBox_Downloads.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBox_Downloads.Name = "groupBox_Downloads";
            this.groupBox_Downloads.Padding = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.groupBox_Downloads.Size = new System.Drawing.Size(486, 555);
            this.groupBox_Downloads.TabIndex = 1;
            this.groupBox_Downloads.TabStop = false;
            this.groupBox_Downloads.Text = "Downloads";
            // 
            // tableLayout_Downloads
            // 
            this.tableLayout_Downloads.ColumnCount = 1;
            this.tableLayout_Downloads.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Downloads.Controls.Add(this.tableLayout_Options, 0, 1);
            this.tableLayout_Downloads.Controls.Add(this.dataGridView_Downloads, 0, 0);
            this.tableLayout_Downloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Downloads.Location = new System.Drawing.Point(3, 16);
            this.tableLayout_Downloads.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayout_Downloads.Name = "tableLayout_Downloads";
            this.tableLayout_Downloads.RowCount = 2;
            this.tableLayout_Downloads.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Downloads.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout_Downloads.Size = new System.Drawing.Size(480, 538);
            this.tableLayout_Downloads.TabIndex = 0;
            // 
            // tableLayout_Filters
            // 
            this.tableLayout_Filters.ColumnCount = 5;
            this.tableLayout_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayout_Filters.Controls.Add(this.checkBox_Audio, 4, 0);
            this.tableLayout_Filters.Controls.Add(this.comboBox_Resolution, 0, 0);
            this.tableLayout_Filters.Controls.Add(this.comboBox_AudioBitRate, 3, 0);
            this.tableLayout_Filters.Controls.Add(this.comboBox_AudioType, 2, 0);
            this.tableLayout_Filters.Controls.Add(this.comboBox_VideoType, 1, 0);
            this.tableLayout_Filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Filters.Location = new System.Drawing.Point(3, 530);
            this.tableLayout_Filters.Name = "tableLayout_Filters";
            this.tableLayout_Filters.RowCount = 1;
            this.tableLayout_Filters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Filters.Size = new System.Drawing.Size(485, 28);
            this.tableLayout_Filters.TabIndex = 3;
            // 
            // checkBox_Audio
            // 
            this.checkBox_Audio.AutoSize = true;
            this.checkBox_Audio.Location = new System.Drawing.Point(395, 3);
            this.checkBox_Audio.Name = "checkBox_Audio";
            this.checkBox_Audio.Padding = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.checkBox_Audio.Size = new System.Drawing.Size(76, 20);
            this.checkBox_Audio.TabIndex = 7;
            this.checkBox_Audio.Text = "Just Audio";
            this.checkBox_Audio.UseVisualStyleBackColor = true;
            // 
            // comboBox_Resolution
            // 
            this.comboBox_Resolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Resolution.FormattingEnabled = true;
            this.comboBox_Resolution.Location = new System.Drawing.Point(3, 3);
            this.comboBox_Resolution.Name = "comboBox_Resolution";
            this.comboBox_Resolution.Size = new System.Drawing.Size(92, 21);
            this.comboBox_Resolution.TabIndex = 4;
            // 
            // comboBox_AudioBitRate
            // 
            this.comboBox_AudioBitRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_AudioBitRate.FormattingEnabled = true;
            this.comboBox_AudioBitRate.Location = new System.Drawing.Point(297, 3);
            this.comboBox_AudioBitRate.Name = "comboBox_AudioBitRate";
            this.comboBox_AudioBitRate.Size = new System.Drawing.Size(92, 21);
            this.comboBox_AudioBitRate.TabIndex = 6;
            // 
            // comboBox_AudioType
            // 
            this.comboBox_AudioType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_AudioType.FormattingEnabled = true;
            this.comboBox_AudioType.Location = new System.Drawing.Point(199, 3);
            this.comboBox_AudioType.Name = "comboBox_AudioType";
            this.comboBox_AudioType.Size = new System.Drawing.Size(92, 21);
            this.comboBox_AudioType.TabIndex = 5;
            // 
            // tableLayout_Options
            // 
            this.tableLayout_Options.ColumnCount = 2;
            this.tableLayout_Options.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayout_Options.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayout_Options.Controls.Add(this.checkBox_DownloadQueue, 0, 0);
            this.tableLayout_Options.Controls.Add(this.checkBox_CloseAfterLast, 1, 0);
            this.tableLayout_Options.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayout_Options.Location = new System.Drawing.Point(244, 514);
            this.tableLayout_Options.Name = "tableLayout_Options";
            this.tableLayout_Options.RowCount = 1;
            this.tableLayout_Options.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Options.Size = new System.Drawing.Size(233, 21);
            this.tableLayout_Options.TabIndex = 0;
            // 
            // checkBox_DownloadQueue
            // 
            this.checkBox_DownloadQueue.AutoSize = true;
            this.checkBox_DownloadQueue.Checked = true;
            this.checkBox_DownloadQueue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DownloadQueue.Location = new System.Drawing.Point(3, 3);
            this.checkBox_DownloadQueue.Name = "checkBox_DownloadQueue";
            this.checkBox_DownloadQueue.Size = new System.Drawing.Size(120, 15);
            this.checkBox_DownloadQueue.TabIndex = 0;
            this.checkBox_DownloadQueue.Text = "Download in Queue";
            this.checkBox_DownloadQueue.UseVisualStyleBackColor = true;
            // 
            // checkBox_CloseAfterLast
            // 
            this.checkBox_CloseAfterLast.AutoSize = true;
            this.checkBox_CloseAfterLast.Location = new System.Drawing.Point(130, 3);
            this.checkBox_CloseAfterLast.Name = "checkBox_CloseAfterLast";
            this.checkBox_CloseAfterLast.Size = new System.Drawing.Size(99, 15);
            this.checkBox_CloseAfterLast.TabIndex = 1;
            this.checkBox_CloseAfterLast.Text = "Close after Last";
            this.checkBox_CloseAfterLast.UseVisualStyleBackColor = true;
            // 
            // comboBox_VideoType
            // 
            this.comboBox_VideoType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_VideoType.FormattingEnabled = true;
            this.comboBox_VideoType.Location = new System.Drawing.Point(101, 3);
            this.comboBox_VideoType.Name = "comboBox_VideoType";
            this.comboBox_VideoType.Size = new System.Drawing.Size(92, 21);
            this.comboBox_VideoType.TabIndex = 8;
            // 
            // dataGridView_Content
            // 
            this.dataGridView_Content.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Content.Location = new System.Drawing.Point(3, 38);
            this.dataGridView_Content.Name = "dataGridView_Content";
            this.dataGridView_Content.Size = new System.Drawing.Size(485, 486);
            this.dataGridView_Content.TabIndex = 4;
            // 
            // dataGridView_Downloads
            // 
            this.dataGridView_Downloads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Downloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Downloads.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Downloads.Name = "dataGridView_Downloads";
            this.dataGridView_Downloads.Size = new System.Drawing.Size(474, 505);
            this.dataGridView_Downloads.TabIndex = 1;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Search.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Search.Location = new System.Drawing.Point(3, 4);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Placeholder = "Search Youtube...";
            this.textBox_Search.Size = new System.Drawing.Size(367, 20);
            this.textBox_Search.TabIndex = 2;
            this.textBox_Search.Text = "Search Youtube...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.splitView_Main);
            this.MinimumSize = new System.Drawing.Size(500, 150);
            this.Name = "MainForm";
            this.Text = "Youtube-Ripperoni-in-Pizza";
            this.splitView_Main.Panel1.ResumeLayout(false);
            this.splitView_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitView_Main)).EndInit();
            this.splitView_Main.ResumeLayout(false);
            this.tableLayout_Content.ResumeLayout(false);
            this.SearchTableLayout.ResumeLayout(false);
            this.SearchTableLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_Downloads.ResumeLayout(false);
            this.tableLayout_Downloads.ResumeLayout(false);
            this.tableLayout_Filters.ResumeLayout(false);
            this.tableLayout_Filters.PerformLayout();
            this.tableLayout_Options.ResumeLayout(false);
            this.tableLayout_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Content)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Downloads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitView_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Content;
        private System.Windows.Forms.TableLayoutPanel SearchTableLayout;
        private System.Windows.Forms.Button button_Search;
        private Controls.TextBoxPlaceHolder textBox_Search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_Downloads;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Downloads;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Filters;
        private System.Windows.Forms.CheckBox checkBox_Audio;
        private System.Windows.Forms.ComboBox comboBox_Resolution;
        private System.Windows.Forms.ComboBox comboBox_AudioBitRate;
        private System.Windows.Forms.ComboBox comboBox_AudioType;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Options;
        private System.Windows.Forms.CheckBox checkBox_DownloadQueue;
        private System.Windows.Forms.CheckBox checkBox_CloseAfterLast;
        private System.Windows.Forms.ComboBox comboBox_VideoType;
        private System.Windows.Forms.DataGridView dataGridView_Content;
        private System.Windows.Forms.DataGridView dataGridView_Downloads;
    }
}

