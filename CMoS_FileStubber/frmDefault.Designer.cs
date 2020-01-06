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
            this.txtHiddenMCEH = new System.Windows.Forms.TextBox();
            this.lblProgressMessage = new System.Windows.Forms.Label();
            this.processBuild = new System.Windows.Forms.ProgressBar();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tabMTCH = new System.Windows.Forms.TabPage();
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
            this.tabMCOH_MCEH.Controls.Add(this.txtHiddenMCEH);
            this.tabMCOH_MCEH.Controls.Add(this.lblProgressMessage);
            this.tabMCOH_MCEH.Controls.Add(this.processBuild);
            this.tabMCOH_MCEH.Controls.Add(this.btnConvert);
            this.tabMCOH_MCEH.Controls.Add(this.txtFeedback);
            this.tabMCOH_MCEH.Controls.Add(this.btnExport);
            this.tabMCOH_MCEH.Controls.Add(this.btnOpen);
            this.tabMCOH_MCEH.Location = new System.Drawing.Point(4, 22);
            this.tabMCOH_MCEH.Name = "tabMCOH_MCEH";
            this.tabMCOH_MCEH.Padding = new System.Windows.Forms.Padding(3);
            this.tabMCOH_MCEH.Size = new System.Drawing.Size(1003, 476);
            this.tabMCOH_MCEH.TabIndex = 0;
            this.tabMCOH_MCEH.Text = "MCOH";
            this.tabMCOH_MCEH.UseVisualStyleBackColor = true;
            // 
            // txtHiddenMCEH
            // 
            this.txtHiddenMCEH.Location = new System.Drawing.Point(628, 6);
            this.txtHiddenMCEH.Multiline = true;
            this.txtHiddenMCEH.Name = "txtHiddenMCEH";
            this.txtHiddenMCEH.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHiddenMCEH.Size = new System.Drawing.Size(350, 405);
            this.txtHiddenMCEH.TabIndex = 6;
            this.txtHiddenMCEH.Visible = false;
            this.txtHiddenMCEH.WordWrap = false;
            // 
            // lblProgressMessage
            // 
            this.lblProgressMessage.AutoSize = true;
            this.lblProgressMessage.Location = new System.Drawing.Point(391, 448);
            this.lblProgressMessage.Name = "lblProgressMessage";
            this.lblProgressMessage.Size = new System.Drawing.Size(0, 13);
            this.lblProgressMessage.TabIndex = 5;
            // 
            // processBuild
            // 
            this.processBuild.Location = new System.Drawing.Point(9, 442);
            this.processBuild.Name = "processBuild";
            this.processBuild.Size = new System.Drawing.Size(376, 23);
            this.processBuild.TabIndex = 4;
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(838, 442);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(73, 24);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // txtFeedback
            // 
            this.txtFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFeedback.Location = new System.Drawing.Point(3, 6);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFeedback.Size = new System.Drawing.Size(994, 426);
            this.txtFeedback.TabIndex = 2;
            this.txtFeedback.WordWrap = false;
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
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(759, 442);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(73, 24);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // tabMTCH
            // 
            this.tabMTCH.Location = new System.Drawing.Point(4, 22);
            this.tabMTCH.Name = "tabMTCH";
            this.tabMTCH.Padding = new System.Windows.Forms.Padding(3);
            this.tabMTCH.Size = new System.Drawing.Size(1003, 476);
            this.tabMTCH.TabIndex = 1;
            this.tabMTCH.Text = "MTCH";
            this.tabMTCH.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TabPage tabMTCH;
        private System.Windows.Forms.Label lblProgressMessage;
        private System.Windows.Forms.ProgressBar processBuild;
        private System.Windows.Forms.Button btnConvert;
        public System.Windows.Forms.TextBox txtHiddenMCEH;
        private System.Windows.Forms.TextBox txtFeedback;
    }
}

