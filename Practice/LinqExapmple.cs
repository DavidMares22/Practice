using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class LinqExapmple
    {
        public static int[] ArrangeXinCenter(int[] numbers, int x) 
        {

            var NonXNumbers = numbers.Where(n => n != x);
            var XNumbers = numbers.Where(n => n == x);


            var findMiddle = NonXNumbers.Count() /  2 ;

            var resultArr = NonXNumbers.Take(findMiddle);

            resultArr = resultArr.Concat(XNumbers);

            resultArr = resultArr.Concat(NonXNumbers.Skip(findMiddle));


            return resultArr.ToArray();
        
        
        
        
        }
    }
}
