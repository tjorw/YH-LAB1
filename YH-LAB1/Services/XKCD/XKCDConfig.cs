namespace YH_LAB1.Services.XKCD
{
    public class XKCDConfig : IXKCDConfig
    {
        public XKCDConfig()
        {
            this.Url = "http://xkcd.com"; // Kunde ha lästs ur en config fil
        }

        public string Url { get; }
    }
}
