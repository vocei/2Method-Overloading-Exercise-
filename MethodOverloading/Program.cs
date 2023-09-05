namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal k, decimal f, decimal e)
        {
            return f + k + e;
        }
        public static string Add(int num1, int num2, bool Truth)
        {
            var sum = num1 + num2;

            if (Truth == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (Truth == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (Truth == true && sum < 1)
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
            var x = 45;
            var y = 66;

            var answer = Add(x, y);

            var a = 120.6m;
            var b = 768.2m;

            var decimalAnswer = Add(a, b);


            var thirdAnswer = Add(0, 1, true);
            var fourthAnswer = Add(0, 14, true);

            var k = 140.4m;
            var f = 300.0m;
            var e = 4.0m;
            var fifthAnswer = Add(k, f, e);

            Console.WriteLine($"First Sum (no decimals): {answer} \nDecimal sum: {decimalAnswer}");
            Console.WriteLine($"Sum with 'dollar': {thirdAnswer}");
            Console.WriteLine($"Fourth Sum with 'dollar': {fourthAnswer}");
            Console.WriteLine($"Fifth Sum with 'dollar' and decimal: {fifthAnswer}");
        }
    }
}
