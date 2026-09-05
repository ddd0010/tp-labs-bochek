class Program
{
    static long? Factorial()
    {
        Console.WriteLine("\nФакториал");
        Console.Write("Введите n (0..20): ");

        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0 || n > 20)
        {
            Console.WriteLine("Ошибка: нужно целое число от 0 до 20.");
            return null;
        }

        long result = Factorial(n);

        Console.WriteLine($"{n}! = {result}");

        static long Factorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }

        return result;
    }

    static string? Fibonacci()
    {
        Console.WriteLine("\nФибоначчи");
        Console.Write("Введите n (0..20): ");

        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0 || n > 20)
        {
            Console.WriteLine("Ошибка: нужно целое число от 0 до 20.");
            return null;
        }

        long a = 0;
        long b = 1;
        string result = "";

        for (int i = 0; i < n; i++)
        {
            if (i > 0)
            {
                result += ", ";
            }

            result += a;

            long temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine(result);
        return result;
    }

    static double? ValueFunction()
    {
        Console.WriteLine("\nВычисление значения функции");
        Console.Write("Введите n (-10..10): ");

        if (!double.TryParse(Console.ReadLine(), out double x) || x < -10.0 || x > 10.0)
        {
            Console.WriteLine("Ошибка: нужно число от -10 до 10.");
            return null;
        }

        double value = Math.Sqrt(Math.Log(4.0 / 3.0)) + (x + 9.0 / 7.0) - Math.Exp(Math.Sin(1.3 * x - 0.7));
        Console.WriteLine(value);

        return value;
    }

    static (double, int)? Taylor()
    {
        Console.WriteLine("\nВычисление ряда Тайлера");
        Console.Write("Введите n (-100..100): ");

        if (!double.TryParse(Console.ReadLine(), out double x) || x < -100.0 || x > 100.0)
        {
            Console.WriteLine("Ошибка: нужно число от -100 до 100.");
            return null;
        }

        double sum = 0.0;
        double term = x;

        int n = 0;
        int count = 0;

        while (Math.Abs(term) > 1e-6)
        {
            sum += term;

            n++;
            count++;

            term *= -x * x / ((2 * n) * (2 * n + 1));
        }

        Console.WriteLine($"Ряд Тайлера: {sum}");
        Console.WriteLine($"Количество просуммированных членов: {count}");
        Console.WriteLine($"Синус: {Math.Sin(x)}");

        return (sum, count);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Доступные меню:");
        Console.WriteLine("1. Вычисление факториала");
        Console.WriteLine("2. Вычисление Фибоначчи");
        Console.WriteLine("3. Вычисление значения функции");
        Console.WriteLine("4. Вычисление ряда Тайлера");
        Console.WriteLine("\nУкажите номер нужного меню: ");

        if (!int.TryParse(Console.ReadLine(), out int menu) || menu < 1 || menu > 4)
        {
            Console.WriteLine("Ошибка: нужен номер от 1 до 4.");
        }
        else
        {
            switch (menu)
            {
                case 1: Factorial(); break;
                case 2: Fibonacci(); break;
                case 3: ValueFunction(); break;
                case 4: Taylor(); break;
            }
        }

        Console.WriteLine("\nНажмите Enter для выхода из программы");
        Console.ReadLine();
    }
}