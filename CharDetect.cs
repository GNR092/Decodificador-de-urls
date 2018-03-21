using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decodificador_de_urls
{
    public class CharDetect
    {
        public Dictionary<string, string> DetectChar = new Dictionary<string, string>();

        public CharDetect()
        {
            DetectChar.Add("%21", "!");
            DetectChar.Add("%23", "#");
            DetectChar.Add("%24", "$");
            DetectChar.Add("%26", "&");
            DetectChar.Add("%27", "'");
            DetectChar.Add("%28", "(");
            DetectChar.Add("%29", ")");
            DetectChar.Add("%2A", "*");
            DetectChar.Add("%2B", "+");
            DetectChar.Add("%2C", ",");
            DetectChar.Add("%2F", "/");
            DetectChar.Add("%3A", ":");
            DetectChar.Add("%3B", ";");
            DetectChar.Add("%3D", "=");
            DetectChar.Add("%3F", "?");
            DetectChar.Add("%40", "@");
            DetectChar.Add("%5B", "[");
            DetectChar.Add("%5D", "]");
        }


        public string CheckString(string str)
        {
            string str1 = str;
            foreach (var Char in DetectChar)
            {
                var s1 = Char.Key;
                int o = str1.IndexOf(s1);
                if (o == -1) continue;
                var newtext = str1.Replace(s1, Char.Value);
                str1 = newtext;
            }
            return str1;
        }
    }
}
