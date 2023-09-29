using System;
using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {
        double a, b;
        int oper;
        Console.WriteLine("Выберите операцию, которую хотите выполнить: ");
        Console.WriteLine("1. сложить два числа");
        Console.WriteLine("2. вычесть первое из второго");
        Console.WriteLine("3. перемножить два числа");
        Console.WriteLine("4. разделить первое на второе");
        Console.WriteLine("5. возвести в n степень первое число");
        Console.WriteLine("6. найти квадратный корень из числа");
        Console.WriteLine("7. найти 1 процент из числа");
        Console.WriteLine("8. найти факториал из числа");
        Console.WriteLine("9. выйти из программы");
        do
        {
            Console.WriteLine("выберите операцию");
            oper = Convert.ToInt32(Console.ReadLine());

            switch (oper)
            {
                case 1:
                    Console.WriteLine("Введите первое число");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    b = double.Parse(Console.ReadLine());

                    Console.Write("Результат: ");
                    Console.WriteLine(a + b);
                    break;
                case 2:
                    Console.WriteLine("Введите первое число");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    b = double.Parse(Console.ReadLine());

                    Console.Write("Результат: ");
                    Console.WriteLine(a - b);
                    break;
                case 3:
                    Console.WriteLine("Введите первое число");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    b = double.Parse(Console.ReadLine());

                    Console.Write("Результат: ");
                    Console.WriteLine(a * b);
                    break;
                case 4:
                    Console.WriteLine("Введите первое число");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    b = double.Parse(Console.ReadLine());
                    for (int i = 1; i < 2; i++)
                        if (b == 0)
                        {
                            Console.WriteLine("Ошибка");
                        }
                        else
                        {
                            Console.Write("Результат: ");
                            Console.WriteLine(a / b);
                        }
                    break;
                case 5:
                    Console.WriteLine("Введите первое число");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Результат: ");
                    Console.WriteLine(Math.Pow(a, b));
                    break;
                case 6:
                    Console.WriteLine("Введите первое число:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($" Результат: {Math.Sqrt(a)}"); ;
                    break;
                case 7:
                    Console.WriteLine("Введите первое число");
                    a = double.Parse(Console.ReadLine());

                    Console.Write("Результат: ");
                    Console.WriteLine(a / 100);
                    break;
                case 8:
                    Console.WriteLine("Введите первое число");
                    a = Convert.ToDouble(Console.ReadLine());
                    double factorial = 1;
                    for (int i = 1; i <= a; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine($"Результат: {factorial}");
                    break;
                case 9:

                    {
                        Console.WriteLine("Bye bye");
                        Process.GetCurrentProcess().Kill();
                        break;
                    }




            }
        } while (oper != 0);



    }
}