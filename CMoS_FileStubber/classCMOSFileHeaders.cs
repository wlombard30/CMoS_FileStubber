using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMoS_FileStubber
{
    public class classCMOSFileHeaders
    {

        string fileColumnHeaders;
        public string columnMCOH_MCEHFileHeaderHeaders()
        {
            fileColumnHeaders = "File Type Identifier, Client Identifier, System Identifier, Service Identifier, Layout Identifier, Layout Revision, Sequence Number, Creation Date, Month, Original Sequence, Return Code, Return Reason";

            return fileColumnHeaders;
        }

        public string columnMCOH_MCEHFileDateHeaders()
        {
            fileColumnHeaders = "Record Type, Collection Method, Deduction Type, Reference Number, Sub Reference, Currency, Country, Initial Amount, Amount, Inflation Update, Inflation Update Percentage, Start Date, End Date, Change Date, Client Action Date, Transaction Number, Original Sequence, Return Code, Return Reason, Quotation Number, Quotation Instance";

            return fileColumnHeaders;
        }

        public string columnMCOH_MCEHFileTrailerHeaders()
        {
            fileColumnHeaders = "Identifier, Record Count, Check Total";

            return fileColumnHeaders;
        }
    }
}
