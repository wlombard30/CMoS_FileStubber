using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Configuration;
using System.Windows.Forms;

namespace CMoS_FileStubber
{
    public class classCMOS_BuildMCEH
    {
        //Reference Header Class
        classCMOSFileHeaders cmosHeaders = new classCMOSFileHeaders();

        readonly OleDbConnection myConn = new OleDbConnection();
        public string myDBConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        public void OpenConnection()
        {
            if (myConn.State == ConnectionState.Closed)
            {
                myConn.ConnectionString = myDBConnectionString;
                myConn.Open();
            }
        }

        //Close DB Connection
        public void CloseConnection()
        {
            myConn.Dispose();
            myConn.Close();
        }
        public void writeMCOHtoDTandDB(frmDefault fMain, string[] fileContents)
        {
            
            //Declare DataTable headers
            DataTable dt_mcohHeader = new DataTable();
            DataTable dt_mcohFileData = new DataTable();
            DataTable dt_mcohTrailer = new DataTable();

            foreach (string mcohline in fileContents)
            {
                string RecordMarker = mcohline.Substring(0, 4);

                string GetMCOHColumnHeaderHeaders = cmosHeaders.columnMCOH_MCEHFileHeaderHeaders();
                string[] SplitMCOHHeaderHeaderStringArray = GetMCOHColumnHeaderHeaders.Split(',');

                string GetMCOHColumnDataHeaders = cmosHeaders.columnMCOH_MCEHFileDataHeaders();
                string[] SplitMCOHDataHeaderStringArray = GetMCOHColumnDataHeaders.Split(',');

                string GetMCOHColumnTrailerHeaders = cmosHeaders.columnMCOH_MCEHFileTrailerHeaders();
                string[] SplitMCOHTrailerHeaderStringArray = GetMCOHColumnTrailerHeaders.Split(',');

                foreach (var DataTableColumnsSplitMCOHHeaderHeaders in SplitMCOHHeaderHeaderStringArray)
                {
                    dt_mcohHeader.Columns.Add(DataTableColumnsSplitMCOHHeaderHeaders);
                }

                foreach (var DataTableColumnsSplitMCOHDataHeaders in SplitMCOHDataHeaderStringArray)
                {
                    dt_mcohFileData.Columns.Add(DataTableColumnsSplitMCOHDataHeaders);
                }

                foreach (var DataTableColumnsSplitMCOHTrailerHeaders in SplitMCOHTrailerHeaderStringArray)
                {
                    dt_mcohTrailer.Columns.Add(DataTableColumnsSplitMCOHTrailerHeaders);
                }

                
                //write the MCOH values to the datatable
                try
                {
                    switch (RecordMarker)
                    {
                        case "MCOH":

                            DataRow row_mcoh = dt_mcohHeader.NewRow();

                            string[] r_header = mcohline.Replace("||", "|").Split('|');

                            row_mcoh["File Type Identifier"] = r_header[0];
                            row_mcoh["Client Identifier"] = r_header[1];
                            row_mcoh["System Identifier"] = r_header[2];
                            row_mcoh["Service Identifier"] = r_header[3];
                            row_mcoh["Layout Identifier"] = r_header[4];
                            row_mcoh["Layout Revision"] = r_header[5];
                            row_mcoh["Sequence Number"] = r_header[6];
                            row_mcoh["Creation Date"] = r_header[7];
                            row_mcoh["Month"] = r_header[8];
                            row_mcoh["Original Sequence"] = r_header[9];
                            row_mcoh["Return Code"] = r_header[10];
                            row_mcoh["Return Reason"] = r_header[11];

                            dt_mcohHeader.Rows.Add(row_mcoh);

                            return;

                        case "MADD":

                            DataRow row_madd = dt_mcohFileData.NewRow();

                            string[] r_madd_data = mcohline.Replace("||", "|").Split('|');

                            row_madd["Record Type"] = r_madd_data[0];
                            row_madd["Collection Method"] = r_madd_data[1];
                            row_madd["Deduction Type"] = r_madd_data[2];
                            row_madd["Reference Number"] = r_madd_data[3];
                            row_madd["Sub Reference"] = r_madd_data[4];
                            row_madd["Currency"] = r_madd_data[5];
                            row_madd["Country"] = r_madd_data[6];
                            row_madd["Initial Amount"] = r_madd_data[7];
                            row_madd["Amount"] = r_madd_data[8];
                            row_madd["Inflation Update"] = r_madd_data[9];
                            row_madd["Inflation Update Percentage"] = r_madd_data[10];
                            row_madd["Start Date"] = r_madd_data[11];
                            row_madd["End Date"] = r_madd_data[12];
                            row_madd["Change Date"] = r_madd_data[13];
                            row_madd["Client Action Date"] = r_madd_data[14];
                            row_madd["Transaction Number"] = r_madd_data[15];
                            row_madd["Original Sequence"] = r_madd_data[16];
                            row_madd["Return Code"] = r_madd_data[17];
                            row_madd["Return Reason"] = r_madd_data[18];
                            row_madd["Quotation Number"] = r_madd_data[19];
                            row_madd["Quotation Instance"] = r_madd_data[20];

                            dt_mcohFileData.Rows.Add(row_madd);
                            
                            return;

                        case "MUPD":

                            DataRow row_mupd = dt_mcohFileData.NewRow();

                            string[] r_mupd_data = mcohline.Replace("||", "|").Split('|');

                            row_mupd["Record Type"] = r_mupd_data[0];
                            row_mupd["Collection Method"] = r_mupd_data[1];
                            row_mupd["Deduction Type"] = r_mupd_data[2];
                            row_mupd["Reference Number"] = r_mupd_data[3];
                            row_mupd["Sub Reference"] = r_mupd_data[4];
                            row_mupd["Currency"] = r_mupd_data[5];
                            row_mupd["Country"] = r_mupd_data[6];
                            row_mupd["Initial Amount"] = r_mupd_data[7];
                            row_mupd["Amount"] = r_mupd_data[8];
                            row_mupd["Inflation Update"] = r_mupd_data[9];
                            row_mupd["Inflation Update Percentage"] = r_mupd_data[10];
                            row_mupd["Start Date"] = r_mupd_data[11];
                            row_mupd["End Date"] = r_mupd_data[12];
                            row_mupd["Change Date"] = r_mupd_data[13];
                            row_mupd["Client Action Date"] = r_mupd_data[14];
                            row_mupd["Transaction Number"] = r_mupd_data[15];
                            row_mupd["Original Sequence"] = r_mupd_data[16];
                            row_mupd["Return Code"] = r_mupd_data[17];
                            row_mupd["Return Reason"] = r_mupd_data[18];
                            row_mupd["Quotation Number"] = r_mupd_data[19];
                            row_mupd["Quotation Instance"] = r_mupd_data[20];

                            dt_mcohFileData.Rows.Add(row_mupd);

                            return;

                        case "MDEL":

                            DataRow row_mdel = dt_mcohFileData.NewRow();

                            string[] r_mdel_data = mcohline.Replace("||", "|").Split('|');

                            row_mdel["Record Type"] = r_mdel_data[0];
                            row_mdel["Collection Method"] = r_mdel_data[1];
                            row_mdel["Deduction Type"] = r_mdel_data[2];
                            row_mdel["Reference Number"] = r_mdel_data[3];
                            row_mdel["Sub Reference"] = r_mdel_data[4];
                            row_mdel["Currency"] = r_mdel_data[5];
                            row_mdel["Country"] = r_mdel_data[6];
                            row_mdel["Initial Amount"] = r_mdel_data[7];
                            row_mdel["Amount"] = r_mdel_data[8];
                            row_mdel["Inflation Update"] = r_mdel_data[9];
                            row_mdel["Inflation Update Percentage"] = r_mdel_data[10];
                            row_mdel["Start Date"] = r_mdel_data[11];
                            row_mdel["End Date"] = r_mdel_data[12];
                            row_mdel["Change Date"] = r_mdel_data[13];
                            row_mdel["Client Action Date"] = r_mdel_data[14];
                            row_mdel["Transaction Number"] = r_mdel_data[15];
                            row_mdel["Original Sequence"] = r_mdel_data[16];
                            row_mdel["Return Code"] = r_mdel_data[17];
                            row_mdel["Return Reason"] = r_mdel_data[18];
                            row_mdel["Quotation Number"] = r_mdel_data[19];
                            row_mdel["Quotation Instance"] = r_mdel_data[20];

                            dt_mcohFileData.Rows.Add(row_mdel);

                            return;

                        case "MPHA":

                            DataRow row_mpha = dt_mcohFileData.NewRow();

                            string[] r_mpha_data = mcohline.Replace("||", "|").Split('|');

                            row_mpha["Record Type"] = r_mpha_data[0];
                            row_mpha["Collection Method"] = r_mpha_data[1];
                            row_mpha["Deduction Type"] = r_mpha_data[2];
                            row_mpha["Reference Number"] = r_mpha_data[3];
                            row_mpha["Sub Reference"] = r_mpha_data[4];
                            row_mpha["Currency"] = r_mpha_data[5];
                            row_mpha["Country"] = r_mpha_data[6];
                            row_mpha["Initial Amount"] = r_mpha_data[7];
                            row_mpha["Amount"] = r_mpha_data[8];
                            row_mpha["Inflation Update"] = r_mpha_data[9];
                            row_mpha["Inflation Update Percentage"] = r_mpha_data[10];
                            row_mpha["Start Date"] = r_mpha_data[11];
                            row_mpha["End Date"] = r_mpha_data[12];
                            row_mpha["Change Date"] = r_mpha_data[13];
                            row_mpha["Client Action Date"] = r_mpha_data[14];
                            row_mpha["Transaction Number"] = r_mpha_data[15];
                            row_mpha["Original Sequence"] = r_mpha_data[16];
                            row_mpha["Return Code"] = r_mpha_data[17];
                            row_mpha["Return Reason"] = r_mpha_data[18];
                            row_mpha["Quotation Number"] = r_mpha_data[19];
                            row_mpha["Quotation Instance"] = r_mpha_data[20];

                            dt_mcohFileData.Rows.Add(row_mpha);

                            return;

                        case "MPHD":

                            DataRow row_mphd = dt_mcohFileData.NewRow();

                            string[] r_mphd_data = mcohline.Replace("||", "|").Split('|');

                            row_mphd["Record Type"] = r_mphd_data[0];
                            row_mphd["Collection Method"] = r_mphd_data[1];
                            row_mphd["Deduction Type"] = r_mphd_data[2];
                            row_mphd["Reference Number"] = r_mphd_data[3];
                            row_mphd["Sub Reference"] = r_mphd_data[4];
                            row_mphd["Currency"] = r_mphd_data[5];
                            row_mphd["Country"] = r_mphd_data[6];
                            row_mphd["Initial Amount"] = r_mphd_data[7];
                            row_mphd["Amount"] = r_mphd_data[8];
                            row_mphd["Inflation Update"] = r_mphd_data[9];
                            row_mphd["Inflation Update Percentage"] = r_mphd_data[10];
                            row_mphd["Start Date"] = r_mphd_data[11];
                            row_mphd["End Date"] = r_mphd_data[12];
                            row_mphd["Change Date"] = r_mphd_data[13];
                            row_mphd["Client Action Date"] = r_mphd_data[14];
                            row_mphd["Transaction Number"] = r_mphd_data[15];
                            row_mphd["Original Sequence"] = r_mphd_data[16];
                            row_mphd["Return Code"] = r_mphd_data[17];
                            row_mphd["Return Reason"] = r_mphd_data[18];
                            row_mphd["Quotation Number"] = r_mphd_data[19];
                            row_mphd["Quotation Instance"] = r_mphd_data[20];

                            dt_mcohFileData.Rows.Add(row_mphd);

                            return;

                        case "MSGL":

                            DataRow row_msgl = dt_mcohFileData.NewRow();

                            string[] r_msgl_data = mcohline.Replace("||", "|").Split('|');

                            row_msgl["Record Type"] = r_msgl_data[0];
                            row_msgl["Collection Method"] = r_msgl_data[1];
                            row_msgl["Deduction Type"] = r_msgl_data[2];
                            row_msgl["Reference Number"] = r_msgl_data[3];
                            row_msgl["Sub Reference"] = r_msgl_data[4];
                            row_msgl["Currency"] = r_msgl_data[5];
                            row_msgl["Country"] = r_msgl_data[6];
                            row_msgl["Initial Amount"] = r_msgl_data[7];
                            row_msgl["Amount"] = r_msgl_data[8];
                            row_msgl["Inflation Update"] = r_msgl_data[9];
                            row_msgl["Inflation Update Percentage"] = r_msgl_data[10];
                            row_msgl["Start Date"] = r_msgl_data[11];
                            row_msgl["End Date"] = r_msgl_data[12];
                            row_msgl["Change Date"] = r_msgl_data[13];
                            row_msgl["Client Action Date"] = r_msgl_data[14];
                            row_msgl["Transaction Number"] = r_msgl_data[15];
                            row_msgl["Original Sequence"] = r_msgl_data[16];
                            row_msgl["Return Code"] = r_msgl_data[17];
                            row_msgl["Return Reason"] = r_msgl_data[18];
                            row_msgl["Quotation Number"] = r_msgl_data[19];
                            row_msgl["Quotation Instance"] = r_msgl_data[20];

                            dt_mcohFileData.Rows.Add(row_msgl);

                            return;

                        case "MDSG":

                            DataRow row_mdsg = dt_mcohFileData.NewRow();

                            string[] r_mdsg_data = mcohline.Replace("||", "|").Split('|');

                            row_mdsg["Record Type"] = r_mdsg_data[0];
                            row_mdsg["Collection Method"] = r_mdsg_data[1];
                            row_mdsg["Deduction Type"] = r_mdsg_data[2];
                            row_mdsg["Reference Number"] = r_mdsg_data[3];
                            row_mdsg["Sub Reference"] = r_mdsg_data[4];
                            row_mdsg["Currency"] = r_mdsg_data[5];
                            row_mdsg["Country"] = r_mdsg_data[6];
                            row_mdsg["Initial Amount"] = r_mdsg_data[7];
                            row_mdsg["Amount"] = r_mdsg_data[8];
                            row_mdsg["Inflation Update"] = r_mdsg_data[9];
                            row_mdsg["Inflation Update Percentage"] = r_mdsg_data[10];
                            row_mdsg["Start Date"] = r_mdsg_data[11];
                            row_mdsg["End Date"] = r_mdsg_data[12];
                            row_mdsg["Change Date"] = r_mdsg_data[13];
                            row_mdsg["Client Action Date"] = r_mdsg_data[14];
                            row_mdsg["Transaction Number"] = r_mdsg_data[15];
                            row_mdsg["Original Sequence"] = r_mdsg_data[16];
                            row_mdsg["Return Code"] = r_mdsg_data[17];
                            row_mdsg["Return Reason"] = r_mdsg_data[18];
                            row_mdsg["Quotation Number"] = r_mdsg_data[19];
                            row_mdsg["Quotation Instance"] = r_mdsg_data[20];

                            dt_mcohFileData.Rows.Add(row_mdsg);

                            return;

                        case "MARR":

                            DataRow row_marr = dt_mcohFileData.NewRow();

                            string[] r_marr_data = mcohline.Replace("||", "|").Split('|');

                            row_marr["Record Type"] = r_marr_data[0];
                            row_marr["Collection Method"] = r_marr_data[1];
                            row_marr["Deduction Type"] = r_marr_data[2];
                            row_marr["Reference Number"] = r_marr_data[3];
                            row_marr["Sub Reference"] = r_marr_data[4];
                            row_marr["Currency"] = r_marr_data[5];
                            row_marr["Country"] = r_marr_data[6];
                            row_marr["Initial Amount"] = r_marr_data[7];
                            row_marr["Amount"] = r_marr_data[8];
                            row_marr["Inflation Update"] = r_marr_data[9];
                            row_marr["Inflation Update Percentage"] = r_marr_data[10];
                            row_marr["Start Date"] = r_marr_data[11];
                            row_marr["End Date"] = r_marr_data[12];
                            row_marr["Change Date"] = r_marr_data[13];
                            row_marr["Client Action Date"] = r_marr_data[14];
                            row_marr["Transaction Number"] = r_marr_data[15];
                            row_marr["Original Sequence"] = r_marr_data[16];
                            row_marr["Return Code"] = r_marr_data[17];
                            row_marr["Return Reason"] = r_marr_data[18];
                            row_marr["Quotation Number"] = r_marr_data[19];
                            row_marr["Quotation Instance"] = r_marr_data[20];

                            dt_mcohFileData.Rows.Add(row_marr);

                            return;

                        case "MDAR":

                            DataRow row_mdar = dt_mcohFileData.NewRow();

                            string[] r_mdar_data = mcohline.Replace("||", "|").Split('|');

                            row_mdar["Record Type"] = r_mdar_data[0];
                            row_mdar["Collection Method"] = r_mdar_data[1];
                            row_mdar["Deduction Type"] = r_mdar_data[2];
                            row_mdar["Reference Number"] = r_mdar_data[3];
                            row_mdar["Sub Reference"] = r_mdar_data[4];
                            row_mdar["Currency"] = r_mdar_data[5];
                            row_mdar["Country"] = r_mdar_data[6];
                            row_mdar["Initial Amount"] = r_mdar_data[7];
                            row_mdar["Amount"] = r_mdar_data[8];
                            row_mdar["Inflation Update"] = r_mdar_data[9];
                            row_mdar["Inflation Update Percentage"] = r_mdar_data[10];
                            row_mdar["Start Date"] = r_mdar_data[11];
                            row_mdar["End Date"] = r_mdar_data[12];
                            row_mdar["Change Date"] = r_mdar_data[13];
                            row_mdar["Client Action Date"] = r_mdar_data[14];
                            row_mdar["Transaction Number"] = r_mdar_data[15];
                            row_mdar["Original Sequence"] = r_mdar_data[16];
                            row_mdar["Return Code"] = r_mdar_data[17];
                            row_mdar["Return Reason"] = r_mdar_data[18];
                            row_mdar["Quotation Number"] = r_mdar_data[19];
                            row_mdar["Quotation Instance"] = r_mdar_data[20];

                            dt_mcohFileData.Rows.Add(row_mdar);

                            return;

                        case "MSUS":

                            DataRow row_msus = dt_mcohFileData.NewRow();

                            string[] r_msus_data = mcohline.Replace("||", "|").Split('|');

                            row_msus["Record Type"] = r_msus_data[0];
                            row_msus["Collection Method"] = r_msus_data[1];
                            row_msus["Deduction Type"] = r_msus_data[2];
                            row_msus["Reference Number"] = r_msus_data[3];
                            row_msus["Sub Reference"] = r_msus_data[4];
                            row_msus["Currency"] = r_msus_data[5];
                            row_msus["Country"] = r_msus_data[6];
                            row_msus["Initial Amount"] = r_msus_data[7];
                            row_msus["Amount"] = r_msus_data[8];
                            row_msus["Inflation Update"] = r_msus_data[9];
                            row_msus["Inflation Update Percentage"] = r_msus_data[10];
                            row_msus["Start Date"] = r_msus_data[11];
                            row_msus["End Date"] = r_msus_data[12];
                            row_msus["Change Date"] = r_msus_data[13];
                            row_msus["Client Action Date"] = r_msus_data[14];
                            row_msus["Transaction Number"] = r_msus_data[15];
                            row_msus["Original Sequence"] = r_msus_data[16];
                            row_msus["Return Code"] = r_msus_data[17];
                            row_msus["Return Reason"] = r_msus_data[18];
                            row_msus["Quotation Number"] = r_msus_data[19];
                            row_msus["Quotation Instance"] = r_msus_data[20];

                            dt_mcohFileData.Rows.Add(row_msus);

                            return;

                        case "MRES":

                            DataRow row_mres = dt_mcohFileData.NewRow();

                            string[] r_mres_data = mcohline.Replace("||", "|").Split('|');

                            row_mres["Record Type"] = r_mres_data[0];
                            row_mres["Collection Method"] = r_mres_data[1];
                            row_mres["Deduction Type"] = r_mres_data[2];
                            row_mres["Reference Number"] = r_mres_data[3];
                            row_mres["Sub Reference"] = r_mres_data[4];
                            row_mres["Currency"] = r_mres_data[5];
                            row_mres["Country"] = r_mres_data[6];
                            row_mres["Initial Amount"] = r_mres_data[7];
                            row_mres["Amount"] = r_mres_data[8];
                            row_mres["Inflation Update"] = r_mres_data[9];
                            row_mres["Inflation Update Percentage"] = r_mres_data[10];
                            row_mres["Start Date"] = r_mres_data[11];
                            row_mres["End Date"] = r_mres_data[12];
                            row_mres["Change Date"] = r_mres_data[13];
                            row_mres["Client Action Date"] = r_mres_data[14];
                            row_mres["Transaction Number"] = r_mres_data[15];
                            row_mres["Original Sequence"] = r_mres_data[16];
                            row_mres["Return Code"] = r_mres_data[17];
                            row_mres["Return Reason"] = r_mres_data[18];
                            row_mres["Quotation Number"] = r_mres_data[19];
                            row_mres["Quotation Instance"] = r_mres_data[20];

                            dt_mcohFileData.Rows.Add(row_mres);

                            return;

                        case "MEND":

                            //Identifier, Record Count, Check Total
                            DataRow row_mend = dt_mcohFileData.NewRow();

                            string[] r_mend_data = mcohline.Replace("||", "|").Split('|');

                            row_mend["Record Type"] = r_mend_data[0];
                            row_mend["Collection Method"] = r_mend_data[1];
                            row_mend["Deduction Type"] = r_mend_data[2];

                            dt_mcohTrailer.Rows.Add(row_mend);

                            return;


                    }

                    //write MCEH string here


                    int t = dt_mcohFileData.Rows.Count - 1;

                    for (int i = 0; i <= t; i++)
                    {
                        //write connect information to db

                        //depending on Record Type it needs to go to 1 of 2 tables

                        //write applicable MCEH line to text box and insert string to table


                    }

                    //write MEND string


                }
                catch
                {
                    string Message = "A new File Marker has been encountered. You sure this file is valid?";
                    string MessageHeader = "Invalid Record Identifier";

                    MessageBox.Show(Message, MessageHeader, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }
            }


        }



    }


}
