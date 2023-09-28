using System;
using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {
        double a, b;
        string oper;                    // действие
        //надо впихнуть цикл операции
        while (true) 
        {
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

            oper = Console.ReadLine();

            Console.WriteLine("Введите первое число");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            b = double.Parse(Console.ReadLine());
            switch (oper)
            {
                case "1":
                    Console.Write("Результат: ");
                    Console.WriteLine(a + b);
                    break;
                case "2":
                    Console.Write("Результат: ");
                    Console.WriteLine(a - b);
                    break;
                    case "9":                 
                    Process.GetCurrentProcess().Kill();                  
                    break;



            }
        }  

    

    }
}