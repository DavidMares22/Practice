using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class Extention
    {

        public static string CapitalizeLetter (this string text)
        {
            return char.ToUpper(text[0]) + text.Substring(1);
        }

       
    }
}
