namespace Youtube_Ripperoni_in_Pizza.Controls
{
    partial class ContentSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayout_Content = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Filters = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_VideoType = new System.Windows.Forms.ComboBox();
            this.comboBox_Resolution = new System.Windows.Forms.ComboBox();
            this.button_AddDownload = new System.Windows.Forms.Button();
            this.tableLayout_Search = new System.Windows.Forms.TableLayoutPanel();
            this.button_Search = new System.Windows.Forms.Button();
            this.dataGridView_Content = new System.Windows.Forms.DataGridView();
            this.comboBox_AudioType = new System.Windows.Forms.ComboBox();
            this.checkBox_OnlyAudio = new System.Windows.Forms.CheckBox();
            this.textBox_Search = new Youtube_Ripperoni_in_Pizza.Controls.TextBoxPlaceHolder();
            this.tableLayout_Content.SuspendLayout();
            this.tableLayout_Filters.SuspendLayout();
            this.tableLayout_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Content)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayout_Content
            // 
            this.tableLayout_Content.ColumnCount = 1;
            this.tableLayout_Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Content.Controls.Add(this.tableLayout_Filters, 0, 2);
            this.tableLayout_Content.Controls.Add(this.tableLayout_Search, 0, 0);
            this.tableLayout_Content.Controls.Add(this.dataGridView_Content, 0, 1);
            this.tableLayout_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Content.Location = new System.Drawing.Point(0, 0);
            this.tableLayout_Content.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout_Content.Name = "tableLayout_Content";
            this.tableLayout_Content.RowCount = 3;
            this.tableLayout_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayout_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayout_Content.Size = new System.Drawing.Size(480, 594);
            this.tableLayout_Content.TabIndex = 1;
            // 
            // tableLayout_Filters
            // 
            this.tableLayout_Filters.ColumnCount = 5;
            this.tableLayout_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayout_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayout_Filters.Controls.Add(this.comboBox_AudioType, 0, 0);
            this.tableLayout_Filters.Controls.Add(this.comboBox_VideoType, 0, 0);
            this.tableLayout_Filters.Controls.Add(this.comboBox_Resolution, 0, 0);
            this.tableLayout_Filters.Controls.Add(this.button_AddDownload, 4, 0);
            this.tableLayout_Filters.Controls.Add(this.checkBox_OnlyAudio, 3, 0);
            this.tableLayout_Filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Filters.Location = new System.Drawing.Point(0, 561);
            this.tableLayout_Filters.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout_Filters.Name = "tableLayout_Filters";
            this.tableLayout_Filters.RowCount = 1;
            this.tableLayout_Filters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Filters.Size = new System.Drawing.Size(480, 33);
            this.tableLayout_Filters.TabIndex = 3;
            // 
            // comboBox_VideoType
            // 
            this.comboBox_VideoType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_VideoType.FormattingEnabled = true;
            this.comboBox_VideoType.Location = new System.Drawing.Point(107, 6);
            this.comboBox_VideoType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.comboBox_VideoType.Name = "comboBox_VideoType";
            this.comboBox_VideoType.Size = new System.Drawing.Size(98, 21);
            this.comboBox_VideoType.TabIndex = 11;
            // 
            // comboBox_Resolution
            // 
            this.comboBox_Resolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Resolution.FormattingEnabled = true;
            this.comboBox_Resolution.Location = new System.Drawing.Point(3, 6);
            this.comboBox_Resolution.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.comboBox_Resolution.Name = "comboBox_Resolution";
            this.comboBox_Resolution.Size = new System.Drawing.Size(98, 21);
            this.comboBox_Resolution.TabIndex = 4;
            // 
            // button_AddDownload
            // 
            this.button_AddDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AddDownload.Location = new System.Drawing.Point(398, 3);
            this.button_AddDownload.Name = "button_AddDownload";
            this.button_AddDownload.Size = new System.Drawing.Size(79, 27);
            this.button_AddDownload.TabIndex = 9;
            this.button_AddDownload.Text = "Download";
            this.button_AddDownload.UseVisualStyleBackColor = true;
            this.button_AddDownload.Click += new System.EventHandler(this.button_AddDownload_Click);
            // 
            // tableLayout_Search
            // 
            this.tableLayout_Search.ColumnCount = 2;
            this.tableLayout_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayout_Search.Controls.Add(this.button_Search, 1, 0);
            this.tableLayout_Search.Controls.Add(this.textBox_Search, 0, 0);
            this.tableLayout_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Search.Location = new System.Drawing.Point(0, 0);
            this.tableLayout_Search.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout_Search.Name = "tableLayout_Search";
            this.tableLayout_Search.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tableLayout_Search.RowCount = 1;
            this.tableLayout_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayout_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayout_Search.Size = new System.Drawing.Size(480, 33);
            this.tableLayout_Search.TabIndex = 2;
            // 
            // button_Search
            // 
            this.button_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Search.Location = new System.Drawing.Point(371, 5);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(106, 23);
            this.button_Search.TabIndex = 1;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // dataGridView_Content
            // 
            this.dataGridView_Content.AllowUserToAddRows = false;
            this.dataGridView_Content.AllowUserToDeleteRows = false;
            this.dataGridView_Content.AllowUserToResizeColumns = false;
            this.dataGridView_Content.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Content.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Content.Location = new System.Drawing.Point(3, 33);
            this.dataGridView_Content.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.dataGridView_Content.Name = "dataGridView_Content";
            this.dataGridView_Content.RowHeadersVisible = false;
            this.dataGridView_Content.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Content.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Content.Size = new System.Drawing.Size(474, 528);
            this.dataGridView_Content.TabIndex = 4;
            this.dataGridView_Content.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Content_RowEnter);
            // 
            // comboBox_AudioType
            // 
            this.comboBox_AudioType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_AudioType.Enabled = false;
            this.comboBox_AudioType.FormattingEnabled = true;
            this.comboBox_AudioType.Location = new System.Drawing.Point(211, 6);
            this.comboBox_AudioType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.comboBox_AudioType.Name = "comboBox_AudioType";
            this.comboBox_AudioType.Size = new System.Drawing.Size(98, 21);
            this.comboBox_AudioType.TabIndex = 12;
            // 
            // checkBox_OnlyAudio
            // 
            this.checkBox_OnlyAudio.AutoSize = true;
            this.checkBox_OnlyAudio.Location = new System.Drawing.Point(315, 9);
            this.checkBox_OnlyAudio.Margin = new System.Windows.Forms.Padding(3, 9, 0, 3);
            this.checkBox_OnlyAudio.Name = "checkBox_OnlyAudio";
            this.checkBox_OnlyAudio.Size = new System.Drawing.Size(77, 17);
            this.checkBox_OnlyAudio.TabIndex = 13;
            this.checkBox_OnlyAudio.Text = "Only Audio";
            this.checkBox_OnlyAudio.UseVisualStyleBackColor = true;
            this.checkBox_OnlyAudio.CheckedChanged += new System.EventHandler(this.checkBox_OnlyAudio_CheckedChanged);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Search.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Search.Location = new System.Drawing.Point(3, 6);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Placeholder = "Search Youtube...";
            this.textBox_Search.Size = new System.Drawing.Size(362, 20);
            this.textBox_Search.TabIndex = 2;
            this.textBox_Search.Text = "Search Youtube...";
            this.textBox_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Search_KeyPress);
            // 
            // ContentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayout_Content);
            this.Name = "ContentSearch";
            this.Size = new System.Drawing.Size(480, 594);
            this.tableLayout_Content.ResumeLayout(false);
            this.tableLayout_Filters.ResumeLayout(false);
            this.tableLayout_Filters.PerformLayout();
            this.tableLayout_Search.ResumeLayout(false);
            this.tableLayout_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Content)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout_Content;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Filters;
        private System.Windows.Forms.ComboBox comboBox_Resolution;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Search;
        private System.Windows.Forms.Button button_Search;
        private TextBoxPlaceHolder textBox_Search;
        private System.Windows.Forms.DataGridView dataGridView_Content;
        private System.Windows.Forms.Button button_AddDownload;
        private System.Windows.Forms.ComboBox comboBox_VideoType;
        private System.Windows.Forms.ComboBox comboBox_AudioType;
        private System.Windows.Forms.CheckBox checkBox_OnlyAudio;
    }
}
