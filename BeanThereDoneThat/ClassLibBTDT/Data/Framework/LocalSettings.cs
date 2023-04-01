namespace ClassLibBTDT.Data
{
    public static class LocalSettings
    {
        private static readonly string connstr = "Data Source=DESKTOP-M604LQ3\\SQLEXPRESS;Initial Catalog=BTDT;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public static string ConnString { get { return connstr; } }
    }
}