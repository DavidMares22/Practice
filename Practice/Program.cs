namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] {1,2,3,4,5,6,7,7 };
            var x = 7;
            var result = LinqExapmple.ArrangeXinCenter(input, x);

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
