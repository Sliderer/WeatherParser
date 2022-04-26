using System;
using System.Collections.Generic;
using System.Text;

namespace Weather
{
    class TownsNameConvector
    {
        private Dictionary<string, string> convertor;

        public TownsNameConvector()
        {
            convertor = new Dictionary<string, string>();
            convertor["Москва"] = "moskva_akademicheskiy";
            convertor["Париж"] = "paris";
            convertor["Вашингтон"] = "washington";
        }

        public string Convert(string townsName)
        {
            return convertor[townsName];
        }
    }
}
