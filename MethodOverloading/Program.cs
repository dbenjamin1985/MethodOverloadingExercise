namespace MethodOverloading
{
    public class Program
    {
        
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool isTrue)
        {
            var sum = x + y;
            if (isTrue == true && sum == 1)
            {
                return $"{sum} dollar"; 
            }
            else if (isTrue == true && sum > 1 && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
            static void Main(string[] args)
        {
            var x = 10;
            var y = 5;

                var answer = Add(x, y, true);

                var a = 16.5m;
                var b = -21.4m;

                var decimalAnswer = Add(a, b);

                var thirdAnswer = Add(200, 189, true);

            Console.WriteLine($"{answer} dollars");
            Console.WriteLine();
            Console.WriteLine($"{decimalAnswer} dollars");
            Console.WriteLine();
            Console.WriteLine(thirdAnswer);
        }
    }
    
}
