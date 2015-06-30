namespace Youtube_Ripperoni_in_Pizza.Controls
{
    partial class Downloads
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Downloads = new System.Windows.Forms.GroupBox();
            this.tableLayout_Downloads = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_Downloads = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_SelectFolder = new System.Windows.Forms.Button();
            this.label_DownloadPath = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_Downloads.SuspendLayout();
            this.tableLayout_Downloads.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Downloads)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 563);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.groupBox_Downloads.Size = new System.Drawing.Size(459, 557);
            this.groupBox_Downloads.TabIndex = 1;
            this.groupBox_Downloads.TabStop = false;
            this.groupBox_Downloads.Text = "Downloads";
            // 
            // tableLayout_Downloads
            // 
            this.tableLayout_Downloads.ColumnCount = 1;
            this.tableLayout_Downloads.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Downloads.Controls.Add(this.dataGridView_Downloads, 0, 0);
            this.tableLayout_Downloads.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayout_Downloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Downloads.Location = new System.Drawing.Point(3, 16);
            this.tableLayout_Downloads.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayout_Downloads.Name = "tableLayout_Downloads";
            this.tableLayout_Downloads.RowCount = 2;
            this.tableLayout_Downloads.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Downloads.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout_Downloads.Size = new System.Drawing.Size(453, 540);
            this.tableLayout_Downloads.TabIndex = 0;
            // 
            // dataGridView_Downloads
            // 
            this.dataGridView_Downloads.AllowUserToAddRows = false;
            this.dataGridView_Downloads.AllowUserToDeleteRows = false;
            this.dataGridView_Downloads.AllowUserToResizeRows = false;
            this.dataGridView_Downloads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Downloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Downloads.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Downloads.Name = "dataGridView_Downloads";
            this.dataGridView_Downloads.RowHeadersVisible = false;
            this.dataGridView_Downloads.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Downloads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Downloads.Size = new System.Drawing.Size(447, 507);
            this.dataGridView_Downloads.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.41943F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.58057F));
            this.tableLayoutPanel2.Controls.Add(this.button_SelectFolder, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_DownloadPath, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 513);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(453, 27);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // button_SelectFolder
            // 
            this.button_SelectFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SelectFolder.Location = new System.Drawing.Point(321, 3);
            this.button_SelectFolder.Name = "button_SelectFolder";
            this.button_SelectFolder.Size = new System.Drawing.Size(129, 21);
            this.button_SelectFolder.TabIndex = 3;
            this.button_SelectFolder.Text = "Select Download Folder";
            this.button_SelectFolder.UseVisualStyleBackColor = true;
            this.button_SelectFolder.Click += new System.EventHandler(this.button_SelectFolder_Click);
            // 
            // label_DownloadPath
            // 
            this.label_DownloadPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_DownloadPath.AutoSize = true;
            this.label_DownloadPath.Location = new System.Drawing.Point(299, 7);
            this.label_DownloadPath.Name = "label_DownloadPath";
            this.label_DownloadPath.Size = new System.Drawing.Size(16, 13);
            this.label_DownloadPath.TabIndex = 4;
            this.label_DownloadPath.Text = "...";
            // 
            // Downloads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Downloads";
            this.Size = new System.Drawing.Size(462, 563);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_Downloads.ResumeLayout(false);
            this.tableLayout_Downloads.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Downloads)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_Downloads;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Downloads;
        private System.Windows.Forms.DataGridView dataGridView_Downloads;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_SelectFolder;
        private System.Windows.Forms.Label label_DownloadPath;
    }
}
