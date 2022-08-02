using System.Net; 

namespace translate_gui;

public class Translator
{
    //public Langs FromLanguage { get; set; }
    public Language FromLanguage { get; set; }
    //public Langs ToLanguage { get; set; }
    public Language ToLanguage { get; set; }
    public string InputText { get; set; }

    public string TranslateText()
    {
        string result;
        try
        {
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={getViewLang(this.FromLanguage)}&tl={getViewLang(this.ToLanguage)}&dt=t&q={this.InputText}";            
            WebClient webClient = new WebClient();
            webClient.Encoding = System.Text.Encoding.UTF8;
            result = webClient.DownloadString(url);
            result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
            
        }
        catch (System.Exception e)
        {
            result = "Error: " + e.Message;
        }
        return result;          
    }

    private string getViewLang(Language lang)
    {
        return lang.CharCode;
        // switch (lang)
        // {
        //     case Langs.English:
        //         return "en";
        //     case Langs.Deutsch:
        //         return "de";
        //     case Langs.France:
        //         return "fr";
        //     case Langs.Русский:
        //         return "ru";
        //     default:
        //         return "en";
        // }
    }     

}