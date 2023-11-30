using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageXMLHelper
{
    internal class ContentLine
    {
        public string Uuid { get; set; }

        public string Language { get; set; }

        public string Root { get; set; }

        public string Content { get; set; }

        public ContentLine()
        {
            
        }

        public ContentLine(string uuid, string language, string root, string content)
        {
            Uuid = uuid;
            Language = language;
            Root = root;
            Content = content;
        }

    }
}
