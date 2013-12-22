using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.XPath;

public class Translator
{

    private string DictionaryXmlFilePath;
    private XPathNavigator ComponentsXmlNavigator;

    public Translator()
    {
        DictionaryXmlFilePath = HttpContext.Current.Server.MapPath("~/App_Data/Dictionary.xml");
        XPathDocument ComponentsXmlDocument = new XPathDocument(DictionaryXmlFilePath);
        ComponentsXmlNavigator = ComponentsXmlDocument.CreateNavigator();
    }

    public string GetTranslation(string WordToTranslate, string Language)
    {
        try
        {
            string WordNodePath = "/Words/" + WordToTranslate.Trim();
            return ComponentsXmlNavigator.SelectSingleNode(WordNodePath + "/" + Language.ToUpper().Trim() + "").Value.Trim();
        }
        catch
        {

            return WordToTranslate;
            

        }
    }
}
