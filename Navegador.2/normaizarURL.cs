using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Navegador._2
{
    class normalizarURL
    {
        public static string NormalizeUrl(string url)
        {
            url.Trim();
            // ^(https)?(http)?://w{3}?\.?\w+\.?\w{3}.*$
            // ^(https)?(http)?://w{3}?\.?\\w+\.?\\w{3}.*$
            Regex completeUrl = new Regex("^(https)?(http)?://w{3}?\\.?\\w+\\.?\\w{3}.*$");

            if (!completeUrl.IsMatch(url))
            {
                return $"https://{url}";
            }

            return url;
        }
    }
}
