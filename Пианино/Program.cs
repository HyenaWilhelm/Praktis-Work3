namespace Пианино
{
    internal class Program
    {
        public static void Main()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            do
            {
                if (key.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("C - C\n" +
                        "C# - NumPad1\n" +
                        "D - D\n" +
                        "D# - NumPad2\n" +
                        "E - E\n" +
                        "F - F\n" +
                        "F# - NumPad3\n" +
                        "G - G\n" +
                        "G# - NumPad4\n" +
                        "A - A\n" +
                        "A# - NumPad5\n " +
                        "B - B");
                    firstOktave();
                    Console.WriteLine("\nПервая октава");

                }
                if (key.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    Console.WriteLine("\nВторая октава");
                    Console.WriteLine("C - C\n" +
                        "C# - NumPad1\n" +
                        "D - D\n" +
                        "D# - NumPad2\n" +
                        "E - E\n" +
                        "F - F\n" +
                        "F# - NumPad3\n" +
                        "G - G\n" +
                        "G# - NumPad4\n" +
                        "A - A\n" +
                        "A# - NumPad5\n " +
                        "B - B");
                    secondOktave();
                }
                if (key.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    Console.WriteLine("\nТретья октава");
                    Console.WriteLine("C - C\n" +
                        "C# - NumPad1\n" +
                        "D - D\n" +
                        "D# - NumPad2\n" +
                        "E - E\n" +
                        "F - F\n" +
                        "F# - NumPad3\n" +
                        "G - G\n" +
                        "G# - NumPad4\n" +
                        "A - A\n" +
                        "A# - NumPad5\n " +
                        "B - B");
                    thridOktave();
                }
            } while (true);
        }
        public static void firstOktave()
        {
            int[] Hz1 = new int[] { 261, 277, 293, 311, 329, 349, 369, 392, 415, 440, 466, 493};
            ConsoleKeyInfo key = Console.ReadKey(true);
            Console.WriteLine("Чтобы выйти в меню нажми Esc");
            if (key.Key == ConsoleKey.C)
            {
                Thread.Sleep(0);
                Console.Beep(Hz1[0], 700);
            }
            if (key.Key == ConsoleKey.NumPad1)
            {
                Thread.Sleep(0);
                Console.Beep(Hz1[1], 700);
            }
            if (key.Key == ConsoleKey.D)
            {
                Thread.Sleep(0);
                Console.Beep(Hz1[2], 700);
            }
            if (key.Key == ConsoleKey.NumPad2)
            {
                Thread.Sleep(0);
                Console.Beep(Hz1[3], 700);
            }
            if (key.Key == ConsoleKey.E)
            {
                Thread.Sleep(0);
                Console.Beep(Hz1[4], 700);
            }
            if (key.Key == ConsoleKey.F)
            {
                Thread.Sleep(0);
                Console.Beep(Hz1[5], 700);
            }
            if (key.Key == ConsoleKey.NumPad3)
            {
                Thread.Sleep(0);
                Console.Beep(Hz1[6], 700);
            }
            if (key.Key == ConsoleKey.G)
            {
                Thread.Sleep(0);
                Console.Beep(Hz1[7], 700);
            }
            if (key.Key == ConsoleKey.NumPad4)
            {
                Thread.Sleep(0);
                Console.Beep(Hz1[8], 700);
            }
            if (key.Key == ConsoleKey.A)
            {
                Thread.Sleep(0);
                Console.Beep(Hz1[9], 700);
            }
            if (key.Key == ConsoleKey.NumPad5)
            {
                Thread.Sleep(0);
                Console.Beep(Hz1[10], 700);
            }
            if (key.Key == ConsoleKey.B)
            {
                Thread.Sleep(0);
                Console.Beep(Hz1[11], 700);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Вы вышли в меню");
                Console.Clear();
                Main();
            }
        }
        public static void secondOktave()
        {
            int[] Hz2 = new int[] { 523, 554, 587, 622, 659, 698, 739, 784, 830, 880, 932, 987};
            ConsoleKeyInfo key = Console.ReadKey(true);
            Console.WriteLine("Чтобы выйти в меню нажми Esc");
            if (key.Key == ConsoleKey.C)
            {
                Thread.Sleep(0);
                Console.Beep(Hz2[0], 700);
            }
            if (key.Key == ConsoleKey.NumPad1)
            {
                Thread.Sleep(0);
                Console.Beep(Hz2[1], 700);
            }
            if (key.Key == ConsoleKey.D)
            {
                Thread.Sleep(0);
                Console.Beep(Hz2[2], 700);
            }
            if (key.Key == ConsoleKey.NumPad2)
            {
                Thread.Sleep(0);
                Console.Beep(Hz2[3], 700);
            }
            if (key.Key == ConsoleKey.E)
            {
                Thread.Sleep(0);
                Console.Beep(Hz2[4], 700);
            }
            if (key.Key == ConsoleKey.F)
            {
                Thread.Sleep(0);
                Console.Beep(Hz2[5], 700);
            }
            if (key.Key == ConsoleKey.NumPad3)
            {
                Thread.Sleep(0);
                Console.Beep(Hz2[6], 700);
            }
            if (key.Key == ConsoleKey.G)
            {
                Thread.Sleep(0);
                Console.Beep(Hz2[7], 700);
            }
            if (key.Key == ConsoleKey.NumPad4)
            {
                Thread.Sleep(0);
                Console.Beep(Hz2[8], 700);
            }
            if (key.Key == ConsoleKey.A)
            {
                Thread.Sleep(0);
                Console.Beep(Hz2[9], 700);
            }
            if (key.Key == ConsoleKey.NumPad5)
            {
                Thread.Sleep(0);
                Console.Beep(Hz2[10], 700);
            }
            if (key.Key == ConsoleKey.B)
            {
                Thread.Sleep(0);
                Console.Beep(Hz2[11], 700);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Вы вышли в меню");
                Console.Clear();
                Main();
            }
        }
        public static void thridOktave()
        {
            int[] Hz3 = new int[] {1046, 1108, 1174, 1244, 1318, 1396, 1480, 1568, 1661, 1720, 1864, 1975};
            ConsoleKeyInfo key = Console.ReadKey(true);
            Console.WriteLine("Чтобы выйти в меню нажми Esc");
            if (key.Key == ConsoleKey.C)
            {
                Thread.Sleep(0);
                Console.Beep(Hz3[0], 700);
            }
            if (key.Key == ConsoleKey.NumPad1)
            {
                Thread.Sleep(0);
                Console.Beep(Hz3[1], 700);
            }
            if (key.Key == ConsoleKey.D)
            {
                Thread.Sleep(0);
                Console.Beep(Hz3[2], 700);
            }
            if (key.Key == ConsoleKey.NumPad2)
            {
                Thread.Sleep(0);
                Console.Beep(Hz3[3], 700);
            }
            if (key.Key == ConsoleKey.E)
            {
                Thread.Sleep(0);
                Console.Beep(Hz3[4], 700);
            }
            if (key.Key == ConsoleKey.F)
            {
                Thread.Sleep(0);
                Console.Beep(Hz3[5], 700);
            }
            if (key.Key == ConsoleKey.NumPad3)
            {
                Thread.Sleep(0);
                Console.Beep(Hz3[6], 700);
            }
            if (key.Key == ConsoleKey.G)
            {
                Thread.Sleep(0);
                Console.Beep(Hz3[7], 700);
            }
            if (key.Key == ConsoleKey.NumPad4)
            {
                Thread.Sleep(0);
                Console.Beep(Hz3[8], 700);
            }
            if (key.Key == ConsoleKey.A)
            {
                Thread.Sleep(0);
                Console.Beep(Hz3[9], 700);
            }
            if (key.Key == ConsoleKey.NumPad5)
            {
                Thread.Sleep(0);
                Console.Beep(Hz3[10], 700);
            }
            if (key.Key == ConsoleKey.B)
            {
                Thread.Sleep(0);
                Console.Beep(Hz3[11], 700);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Вы вышли в меню");
                Console.Clear();
                Main();
            }
        }
    }
}