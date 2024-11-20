using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageXMLHelper.TranslateAPIs
{
    public interface ITranslateAPI
    {
        string TranslateTrToEn(string trContent);
    }
}
