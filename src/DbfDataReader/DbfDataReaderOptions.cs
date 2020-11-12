using System.Text;

namespace DbfDataReader
{
    public class DbfDataReaderOptions
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/api/system.text.codepagesencodingprovider?redirectedfrom=MSDN&view=net-5.0#Anchor_4
        /// </summary>
        public DbfDataReaderOptions()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            SkipDeletedRecords = false;
            Encoding = Encoding.GetEncoding(1252); // https://stackoverflow.com/questions/50858209/system-notsupportedexception-no-data-is-available-for-encoding-1252
        }

        public bool SkipDeletedRecords { get; set; }
        public Encoding Encoding { get; set; }
    }
}