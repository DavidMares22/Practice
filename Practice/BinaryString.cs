using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class BinaryString
    {

        public static bool CheckIfStringIsBinary(string input)
        {

            foreach (var item in input) {

                if (item != '0' && item != '1')
                {
                    return false;
                }
            
            }

            return true;
        }

        public static bool CheckIfStringIsBinary2(string input)
        {
            return input.All(c => c == '0' || c == '1');
        }

        public static bool CheckIfStringIsBinary3(string input)
        {
            return !input.Any(c => c != '0' && c != '1');

        }

    }
}
