class Program
{
    static void Factorial()
    {
        Console.WriteLine("\nФакториал");
        Console.Write("Введите n (0..20): ");

        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0 || n > 20)
        {
            Console.WriteLine("Ошибка: нужно целое число от 0 до 20.");
            return;
        }

        Console.WriteLine($"{n}! = {Factorial(n)}");

        static long Factorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }
    }

    static void Fibonacci()
    {
        Console.WriteLine("\nФибоначчи");
        Console.WriteLine("Введите n (0..20): ");

        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0 || n > 20)
        {
            Console.WriteLine("Ошибка: нужно целое число от 0 до 20.");
            return;
        }

        long a = 0;
        long b = 1;

        for (int i = 0; i < n; i++)
        {
            if (i > 0)
            {
                Console.Write(", ");
            }

            Console.Write(a);

            long temp = a;
            a = b;
            b = temp + b;
        }


    }

    static void Main(string[] args)
    {
        Factorial();
        Fibonacci();

        Console.ReadLine();
    }
}