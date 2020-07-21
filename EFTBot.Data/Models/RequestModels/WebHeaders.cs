namespace EFTBot.Data.Models.RequestModels
{
    public class WebHeader
    {
        public string HeaderKey { get; set; }
        public string HeaderValue { get; set; }

        public WebHeader()
        {

        }

        public WebHeader(string key, string val)
        {
            HeaderKey = key;
            HeaderValue = val;
        }
    }
}
