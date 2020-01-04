namespace CMoS_FileStubber
{
    partial class frmDefault
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
            if (disposing && (components != null))
            {
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.browseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabMCOH_MCEH = new System.Windows.Forms.TabPage();
            this.tabMTCH = new System.Windows.Forms.TabPage();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.tabMain.SuspendLayout();
            this.tabMCOH_MCEH.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileImporter";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabMCOH_MCEH);
            this.tabMain.Controls.Add(this.tabMTCH);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1011, 502);
            this.tabMain.TabIndex = 3;
            // 
            // tabMCOH_MCEH
            // 
            this.tabMCOH_MCEH.Controls.Add(this.txtFeedback);
            this.tabMCOH_MCEH.Controls.Add(this.btnExport);
            this.tabMCOH_MCEH.Controls.Add(this.btnOpen);
            this.tabMCOH_MCEH.Location = new System.Drawing.Point(4, 22);
            this.tabMCOH_MCEH.Name = "tabMCOH_MCEH";
            this.tabMCOH_MCEH.Padding = new System.Windows.Forms.Padding(3);
            this.tabMCOH_MCEH.Size = new System.Drawing.Size(1003, 476);
            this.tabMCOH_MCEH.TabIndex = 0;
            this.tabMCOH_MCEH.Text = "MCEH";
            this.tabMCOH_MCEH.UseVisualStyleBackColor = true;
            // 
            // tabMTCH
            // 
            this.tabMTCH.Location = new System.Drawing.Point(4, 22);
            this.tabMTCH.Name = "tabMTCH";
            this.tabMTCH.Padding = new System.Windows.Forms.Padding(3);
            this.tabMTCH.Size = new System.Drawing.Size(1005, 483);
            this.tabMTCH.TabIndex = 1;
            this.tabMTCH.Text = "MTCH";
            this.tabMTCH.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(836, 442);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(73, 24);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(917, 442);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(73, 24);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // txtFeedback
            // 
            this.txtFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFeedback.Location = new System.Drawing.Point(3, 6);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(994, 426);
            this.txtFeedback.TabIndex = 2;
            // 
            // frmDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 502);
            this.Controls.Add(this.tabMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDefault";
            this.Text = "CMoS File Stubber";
            this.tabMain.ResumeLayout(false);
            this.tabMCOH_MCEH.ResumeLayout(false);
            this.tabMCOH_MCEH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.FolderBrowserDialog browseFolder;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabMCOH_MCEH;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TabPage tabMTCH;
    }
}

