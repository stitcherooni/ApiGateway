namespace DocumentCreator
{
    public class HtmlCreator
    {
        public string Create()
        {
            string htmlDocument = File.ReadAllText("1.html");
            return htmlDocument;
        }
    }
}
