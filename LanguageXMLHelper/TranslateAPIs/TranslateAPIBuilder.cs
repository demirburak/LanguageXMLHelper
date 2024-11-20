using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageXMLHelper.TranslateAPIs
{
    public static class TranslateAPIBuilder
    {
        public static ITranslateAPI Build(ApiSource apiSource)
        {
            if (apiSource == ApiSource.Test)
            {
                return new TestTranslateAPI();
            }

            return new TestTranslateAPI();
        }
    }
}
