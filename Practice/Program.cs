namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // BinaryStringExample();

            // ExtentionExample();

            //LinqExample();

            LongestEvenWordExample();

            //SingletonExample();






        }

        static void SingletonExample()
        {
            var s1 = Singleton.Instance;
            var s2 = Singleton.Instance;

            Console.WriteLine($"{s1.Guid} and {s2.Guid}");
            Console.WriteLine(object.ReferenceEquals(s1,s2));
        }

        static void LongestEvenWordExample()
        {
            Console.WriteLine(LongestEvenWord.FindLongestEvenWord2("Hello my name is David. Also what happend the other day in the museum"));
        }

        static void LinqExample() {

            var input = new int[] { 1, 2, 3, 4, 5, 6, 7, 7 };
            var x = 7;
            var result = LinqExapmple.ArrangeXinCenter(input, x);

            Console.WriteLine(string.Join(" ", result));
        }

        static void ExtentionExample()
        {
            //Prints "Hello"
            Console.WriteLine("hello".CapitalizeLetter());
        }


        static void BinaryStringExample() 
        { 
            //Prints true because the string contains only 1s and 0s
            Console.WriteLine(BinaryString.CheckIfStringIsBinary3("0001000"));


        }
    }
}
