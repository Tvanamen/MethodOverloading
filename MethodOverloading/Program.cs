namespace MethodOverloading
{
    internal class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isTrue)
        {
            var sum = a + b;

            if (isTrue == true && sum > 1)
            {
                return $"{sum} Dollars";
            }
            else if (isTrue == true && sum == 1)
            {
                return $"{sum} Dollar";
            }
            else if (isTrue == true && sum < 1)
            {
                return $"{sum} Dollars";
            }
            else
            {
                return sum.ToString();
            }

        }
        public static void Main(string[] args)
        {
            var a = 32;
            var b = 16;

            var addAnwser = Add(a, b);

            var x = 8.3m;
            var y = 13.2m;

            var decimalAnwser = Add(x, y);

            var money = Add(2, 6, true);
            System.Console.WriteLine($"Addition method: {addAnwser} Decimal anwser: {decimalAnwser}");
            System.Console.WriteLine($"Money Awnser: {money}");

        }
    }

}
