class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите программу, которую хотите запустить");
            Console.WriteLine("1.Угадай число");
            Console.WriteLine("2.Таблица умножения");
            Console.WriteLine("3.Вывод делителей числа");
            Console.WriteLine("4.Закрыть программу");

            int game = Convert.ToInt32(Console.ReadLine());

            if (game == 1)
            {
                Ga();
            }
            if (game == 2)
            {
                Gb();
            }

            if (game == 3)
            {
                Gc();
            }
            if (game == 4)
            {
                break;
            }
            if (game > 4)
            {
                Console.WriteLine("Ошибка");
            }
        }

    }
    static void Ga()
    {

        Console.WriteLine("Угадай число от 0 до 100!");

        Random rnd = new Random(); //задаем рандом

        int a = rnd.Next(100);// а это загаданное число с диапозоном
        int b;
        do //цикл сюда           
        {
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Надо больше");
            }
            if (a < b)
            {
                Console.WriteLine("Надо меньше");
            }
            if (a == b)
            {
                Console.WriteLine("Ура, победа!");
            }
        } while (a != b);
    }

    static void Gb()
    {
        var table = new int[10, 10];
        for (int i = 0; i < 10; ++i)
        {
            for (int j = 0; j < 10; ++j)
            {
                table[i, j] = i * j;
            }
        }
        for (int i = 0; i < 10; ++i)
        {
            for (int j = 0; j < 10; ++j)
            {
                Console.Write("{0, 3}", table[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void Gc()
    {        
        Console.WriteLine("Введите число:");
        int c = Convert.ToInt32(Console.ReadLine());
        for (int d = 1; d <= c; d++)
        {
            if (c % d == 0)
                Console.Write("{0}", d + "\t");
        }
        Console.WriteLine("");
    }
}