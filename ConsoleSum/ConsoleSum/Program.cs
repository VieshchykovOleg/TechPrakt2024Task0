namespace ConsoleSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть перше число:");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.Write("Введіть друге число:");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    double sum = num1 + num2;
                    Console.WriteLine($"Сума двох чисел: {sum}");
                }
                else
                {
                    Console.WriteLine("Помилка. Введіть коректне друге число.");
                }
            }
            else
            {
                Console.WriteLine("Помилка. Введіть коректне перше число.");
            }

        }
    }
}