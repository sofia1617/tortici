namespace tortiki
{
    internal class Dop
    {
        public static int pos = 0;

        public static void Postition(ConsoleKey key, int min, int max)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    pos--;
                    if (pos < min)
                    {
                        pos = max - 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    pos++;
                    if (pos >= max)
                    {
                        pos = min;
                    }
                    break;

            }
        }
        public static void Strelochka()
        {
            Console.SetCursorPosition(0, pos);
            Console.WriteLine(" --> ");
        }
    }
}

