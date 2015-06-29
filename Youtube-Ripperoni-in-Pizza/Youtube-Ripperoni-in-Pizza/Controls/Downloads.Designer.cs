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
            this.tableLayout_Options = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_DownloadQueue = new System.Windows.Forms.CheckBox();
            this.checkBox_CloseAfterLast = new System.Windows.Forms.CheckBox();
            this.dataGridView_Downloads = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_Downloads.SuspendLayout();
            this.tableLayout_Downloads.SuspendLayout();
            this.tableLayout_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Downloads)).BeginInit();
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
            this.tableLayout_Downloads.Controls.Add(this.tableLayout_Options, 0, 1);
            this.tableLayout_Downloads.Controls.Add(this.dataGridView_Downloads, 0, 0);
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
            // tableLayout_Options
            // 
            this.tableLayout_Options.ColumnCount = 2;
            this.tableLayout_Options.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayout_Options.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayout_Options.Controls.Add(this.checkBox_DownloadQueue, 0, 0);
            this.tableLayout_Options.Controls.Add(this.checkBox_CloseAfterLast, 1, 0);
            this.tableLayout_Options.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayout_Options.Location = new System.Drawing.Point(217, 516);
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
            // dataGridView_Downloads
            // 
            this.dataGridView_Downloads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Downloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Downloads.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Downloads.Name = "dataGridView_Downloads";
            this.dataGridView_Downloads.Size = new System.Drawing.Size(447, 507);
            this.dataGridView_Downloads.TabIndex = 1;
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
            this.tableLayout_Options.ResumeLayout(false);
            this.tableLayout_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Downloads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_Downloads;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Downloads;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Options;
        private System.Windows.Forms.CheckBox checkBox_DownloadQueue;
        private System.Windows.Forms.CheckBox checkBox_CloseAfterLast;
        private System.Windows.Forms.DataGridView dataGridView_Downloads;
    }
}
