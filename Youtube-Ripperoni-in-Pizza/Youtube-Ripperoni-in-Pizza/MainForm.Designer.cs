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
            this.contentSearch = new Youtube_Ripperoni_in_Pizza.Controls.ContentSearch();
            this.downloads = new Youtube_Ripperoni_in_Pizza.Controls.Downloads();
            ((System.ComponentModel.ISupportInitialize)(this.splitView_Main)).BeginInit();
            this.splitView_Main.Panel1.SuspendLayout();
            this.splitView_Main.Panel2.SuspendLayout();
            this.splitView_Main.SuspendLayout();
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
            this.splitView_Main.Panel1.Controls.Add(this.contentSearch);
            this.splitView_Main.Panel1MinSize = 200;
            // 
            // splitView_Main.Panel2
            // 
            this.splitView_Main.Panel2.Controls.Add(this.downloads);
            this.splitView_Main.Panel2MinSize = 200;
            this.splitView_Main.Size = new System.Drawing.Size(984, 561);
            this.splitView_Main.SplitterDistance = 491;
            this.splitView_Main.TabIndex = 0;
            // 
            // contentSearch
            // 
            this.contentSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentSearch.Location = new System.Drawing.Point(0, 0);
            this.contentSearch.Name = "contentSearch";
            this.contentSearch.Size = new System.Drawing.Size(491, 561);
            this.contentSearch.TabIndex = 0;
            // 
            // downloads
            // 
            this.downloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloads.Location = new System.Drawing.Point(0, 0);
            this.downloads.Name = "downloads";
            this.downloads.Size = new System.Drawing.Size(489, 561);
            this.downloads.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitView_Main;
        private Controls.ContentSearch contentSearch;
        private Controls.Downloads downloads;
    }
}

