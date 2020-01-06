using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMoS_FileStubber
{
    public partial class frmDefault : Form
    {

        //Declaration of class instances
        readonly UpdateProgressbarDuringWrite upProgress = new UpdateProgressbarDuringWrite();

        classCMOS_BuildMCEH writeDBandMCEH = new classCMOS_BuildMCEH();

        public frmDefault()
        {
            InitializeComponent();
            upProgress.UpdateProgress += UpdateProgress;
        }


        private void UpdateProgress(int ProgressPercentage)
        {
            processBuild.Value = ProgressPercentage;
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            //Declare Message Variables
            //string msgBody;
            //string msgCaption;

            //Reset Text Space
            txtFeedback.Text = "";

            OpenFileDialog openMCOHfile = new OpenFileDialog
            {
                Title = "Load the Generated MCOH file"
            };

            openMCOHfile.Filter = "Text File (*.txt)|*.txt";
            openMCOHfile.FilterIndex = 1;

            if (openMCOHfile.ShowDialog() == DialogResult.OK)
            {
                StreamReader mcohReader = new StreamReader(openMCOHfile.FileName);
                string cmosline = mcohReader.ReadLine();

                while (cmosline != null)
                {
                    try
                    {
                        txtFeedback.AppendText(cmosline + Environment.NewLine);
                        cmosline = mcohReader.ReadLine();
                    }
                    catch
                    {
                        return;
                    }
                }

                

                //int totalLength = txtFeedback.Lines.Count() - 1;

                
                //insert class that will use contents of textbox to split each line of Header, Contents and Trailer into separate DataTables.
                //It will depend on first 4 letters of substring.


            }


        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            string mcehFileExport = txtFeedback.Text;

            if (browseFolder.ShowDialog() == DialogResult.OK)
            {
                TextWriter writeMCEH = new StreamWriter(browseFolder.SelectedPath + "TO DO:Insert Filename here.txt");

                writeMCEH.WriteLine(mcehFileExport);
                writeMCEH.Close();

                MessageBox.Show("MCEH file has been exported", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //Update ProgressBar
            Application.DoEvents();
            processBuild.Value = 0;

            try
            {
                txtHiddenMCEH.Text = "";
                string[] CMoSLines = txtFeedback.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                writeDBandMCEH.writeMCOHtoDTandDB(this, CMoSLines);

                MessageBox.Show("MCEH File contents created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
