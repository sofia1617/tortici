using System;
using System.Drawing;
using System.IO;
using System.Runtime.Intrinsics.X86;

namespace tortiki
{
    internal class Program
    {
        public static string[] zakaz_names;
        public static int[] zakaz_ceni;

        static void Main(string[] args)
        {
            while (true)
            {
                zakaz_names = new string[7];
                zakaz_ceni = new int[7];
                Console.WriteLine("Если вы хотите закать тортик - нажмите ENTER");
                Console.WriteLine("Если вы ошиблись или передумали - нажмите ESC");
                ConsoleKey Key = Console.ReadKey().Key;
                switch (Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Menu();
                        int cena = 0;
                        for (int i = 0; i < zakaz_ceni.Length; i++)
                        {
                            cena += zakaz_ceni[i];
                        }
                        string zakaz = "";
                        for (int i = 0; i < zakaz_names.Length; i++)
                        {
                            if (zakaz_names[i] != null)
                            {
                                zakaz += "\n    " + zakaz_names[i] + " - " + zakaz_ceni[i];
                            }
                        }
                        DateTime date = DateTime.Now;
                        string text = "Заказ от " + date + ":\n  Заказ: " + zakaz + "\n  Цена: " + cena + "\n";
                        File.AppendAllText("D:\\История заказов.txt", text);
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.SetCursorPosition(1, 0);
                        Console.WriteLine("Любим Вас, до свидания!");
                        return;
                }
            }
        }
        static void Menu()
        {
            Dop.pos = 0;
            while (true)
            {
                Console.WriteLine("  1. Форма тортика \n  2. Размер тортика \n  3. Количество коржиков \n  4. Вид коржиков \n  5. Начиночка \n  6. Глазурь \n  7. Декор тортика \n  8. Сделать заказ \n");
                int cena = 0;
                for (int i = 0; i < zakaz_ceni.Length; i++)
                {
                    cena += zakaz_ceni[i];
                }
                Console.WriteLine("Итоговая цена: " + cena);
                Console.WriteLine("Ваш торт:");
                for (int i = 0; i < zakaz_names.Length; i++)
                {
                    if (zakaz_names[i] != null)
                    {
                        Console.WriteLine("  " + zakaz_names[i] + " - " + zakaz_ceni[i]);
                    }
                }

                Dop.Strelochka();
                ConsoleKey Key = Console.ReadKey().Key;
                Dop.Postition(Key, 0, 8);

                if (Dop.pos == 0 && Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    PodMenu1();
                    Dop.pos = 0;
                }
                else if (Dop.pos == 1 && Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    PodMenu2();
                    Dop.pos = 1;
                }
                else if (Dop.pos == 2 && Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    PodMenu3();
                    Dop.pos = 2;
                }
                else if (Dop.pos == 3 && Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    PodMenu4();
                    Dop.pos = 3;
                }
                else if (Dop.pos == 4 && Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    PodMenu5();
                    Dop.pos = 4;
                }
                else if (Dop.pos == 5 && Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    PodMenu6();
                    Dop.pos = 5;
                }
                else if (Dop.pos == 6 && Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    PodMenu7();
                    Dop.pos = 6;
                }
                else if (Dop.pos == 7 && Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    return;
                }
                Console.Clear();
            }
        }
        static void PodMenu1()
        {
            Dop.pos = 1;
            while (true)
            {
                Console.WriteLine("Выберите форму тортика: ");
                int cena = 99;
                int cena1 = 149;
                int cena2 = 199;
                string forma = "Квадрат";
                string forma1 = "Круг";
                string forma2 = "Прямоугольник";
                Console.WriteLine("     " + forma + " - " + cena);
                Console.WriteLine("     " + forma1 + " - " + cena1);
                Console.WriteLine("     " + forma2 + " - " + cena2);
                Dop.Strelochka();
                ConsoleKey Key = Console.ReadKey().Key;
                Dop.Postition(Key, 1, 4);

                switch (Key)
                {
                    case ConsoleKey.Enter:
                        if (Dop.pos == 1)
                        {
                            zakaz_names[0] = forma;
                            zakaz_ceni[0] = cena;
                        }
                        else if (Dop.pos == 2)
                        {
                            zakaz_names[0] = forma1;
                            zakaz_ceni[0] = cena1;
                        }
                        else if (Dop.pos == 3)
                        {
                            zakaz_names[0] = forma2;
                            zakaz_ceni[0] = cena2;
                        }
                        return;
                }

                Console.Clear();
            }
        }
        static void PodMenu2()
        {
            Dop.pos = 1;
            while (true)
            {
                Console.WriteLine("Выберите размер тортика: ");
                int cena = 199;
                int cena1 = 249;
                int cena2 = 299;
                string razmer = "Маленький";
                string razmer1 = "Средний";
                string razmer2 = "Большой";
                Console.WriteLine("     " + razmer + " - " + cena);
                Console.WriteLine("     " + razmer1 + " - " + cena1);
                Console.WriteLine("     " + razmer2 + " - " + cena2);
                Dop.Strelochka();
                ConsoleKey Key = Console.ReadKey().Key;
                Dop.Postition(Key, 1, 4);

                switch (Key)
                {
                    case ConsoleKey.Enter:
                        if (Dop.pos == 1)
                        {
                            zakaz_names[1] = razmer;
                            zakaz_ceni[1] = cena;
                        }
                        else if (Dop.pos == 2)
                        {
                            zakaz_names[1] = razmer1;
                            zakaz_ceni[1] = cena1;
                        }
                        else if (Dop.pos == 3)
                        {
                            zakaz_names[1] = razmer2;
                            zakaz_ceni[1] = cena2;
                        }
                        return;
                }

                Console.Clear();
            }
        }
        static void PodMenu3()
        {
            Dop.pos = 1;
            while (true)
            {
                Console.WriteLine("Выберите вкус коржиков: ");
                int cena = 99;
                int cena1 = 199;
                int cena2 = 299;
                string vkys = "Шоколадный";
                string vkys1 = "Классический";
                string vkys2 = "Классический с орехами";
                Console.WriteLine("     " + vkys + " - " + cena);
                Console.WriteLine("     " + vkys1 + " - " + cena1);
                Console.WriteLine("     " + vkys2 + " - " + cena2);
                Dop.Strelochka();
                ConsoleKey Key = Console.ReadKey().Key;
                Dop.Postition(Key, 1, 4);

                switch (Key)
                {
                    case ConsoleKey.Enter:
                        if (Dop.pos == 1)
                        {
                            zakaz_names[2] = vkys;
                            zakaz_ceni[2] = cena;
                        }
                        else if (Dop.pos == 2)
                        {
                            zakaz_names[2] = vkys1;
                            zakaz_ceni[2] = cena1;
                        }
                        else if (Dop.pos == 3)
                        {
                            zakaz_names[2] = vkys2;
                            zakaz_ceni[2] = cena2;
                        }
                        return;
                }

                Console.Clear();
            }
        }
        static void PodMenu4()
        {
            Dop.pos = 1;
            while (true)
            {
                Console.WriteLine("Выберите количество коржиков: ");
                int cena = 49;
                int cena1 = 79;
                int cena2 = 99;
                string colvo = "Один коржик";
                string colvo1 = "Два коржика";
                string colvo2 = "Три коржика";
                Console.WriteLine("     " + colvo + " - " + cena);
                Console.WriteLine("     " + colvo1 + " - " + cena1);
                Console.WriteLine("     " + colvo2 + " - " + cena2);
                Dop.Strelochka();
                ConsoleKey Key = Console.ReadKey().Key;
                Dop.Postition(Key, 1, 4);

                switch (Key)
                {
                    case ConsoleKey.Enter:
                        if (Dop.pos == 1)
                        {
                            zakaz_names[3] = colvo;
                            zakaz_ceni[3] = cena;
                        }
                        else if (Dop.pos == 2)
                        {
                            zakaz_names[3] = colvo1;
                            zakaz_ceni[3] = cena1;
                        }
                        else if (Dop.pos == 3)
                        {
                            zakaz_names[3] = colvo2;
                            zakaz_ceni[3] = cena2;
                        }
                        return;
                }

                Console.Clear();
            }
        }
        static void PodMenu5()
        {
            Dop.pos = 1;
            while (true)
            {


                Console.WriteLine("Выберите начинку тортика: ");
                int cena = 149;
                int cena1 = 199;
                int cena2 = 249;
                string nachunka = "Ваниль";
                string nachunka1 = "Шоколад";
                string nachunka2 = "Мята-клбника";
                Console.WriteLine("     " + nachunka + " - " + cena);
                Console.WriteLine("     " + nachunka1 + " - " + cena1);
                Console.WriteLine("     " + nachunka2 + " - " + cena2);
                Dop.Strelochka();
                ConsoleKey Key = Console.ReadKey().Key;
                Dop.Postition(Key, 1, 4);

                switch (Key)
                {
                    case ConsoleKey.Enter:
                        if (Dop.pos == 1)
                        {
                            zakaz_names[4] = nachunka;
                            zakaz_ceni[4] = cena;
                        }
                        else if (Dop.pos == 2)
                        {
                            zakaz_names[4] = nachunka1;
                            zakaz_ceni[4] = cena1;
                        }
                        else if (Dop.pos == 3)
                        {
                            zakaz_names[4] = nachunka2;
                            zakaz_ceni[4] = cena2;
                        }
                        return;
                }

                Console.Clear();
            }
        }
        static void PodMenu6()
        {
            Dop.pos = 1;
            while (true)
            {
                Console.WriteLine("Выберите глазурь для тортика: ");
                int cena = 99;
                int cena1 = 99;
                int cena2 = 99;
                string glazyr = "Молочный шоколад";
                string glazyr1 = "Тёмный шоколад";
                string glazyr2 = "Белый шоколад";
                Console.WriteLine("     " + glazyr + " - " + cena);
                Console.WriteLine("     " + glazyr1 + " - " + cena1);
                Console.WriteLine("     " + glazyr2 + " - " + cena2);
                Dop.Strelochka();
                ConsoleKey Key = Console.ReadKey().Key;
                Dop.Postition(Key, 1, 4);

                switch (Key)
                {
                    case ConsoleKey.Enter:
                        if (Dop.pos == 1)
                        {
                            zakaz_names[5] = glazyr;
                            zakaz_ceni[5] = cena;
                        }
                        else if (Dop.pos == 2)
                        {
                            zakaz_names[5] = glazyr1;
                            zakaz_ceni[5] = cena1;
                        }
                        else if (Dop.pos == 3)
                        {
                            zakaz_names[5] = glazyr2;
                            zakaz_ceni[5] = cena2;
                        }
                        return;
                }

                Console.Clear();
            }
        }
        static void PodMenu7()
        {
            Dop.pos = 1;
            while (true)
            {
                Console.WriteLine("Выберите декор для тортика: ");
                int cena = 149;
                int cena1 = 199;
                int cena2 = 349;
                string dekor = "Цветы из мастики";
                string dekor1 = "Свежие ягоды";
                string dekor2 = "Надпись + съедобные фотографии";
                Console.WriteLine("     " + dekor + " - " + cena);
                Console.WriteLine("     " + dekor1 + " - " + cena1);
                Console.WriteLine("     " + dekor2 + " - " + cena2);
                Dop.Strelochka();
                ConsoleKey Key = Console.ReadKey().Key;
                Dop.Postition(Key, 1, 4);

                switch (Key)
                {
                    case ConsoleKey.Enter:
                        if (Dop.pos == 1)
                        {
                            zakaz_names[6] = dekor;
                            zakaz_ceni[6] = cena;
                        }
                        else if (Dop.pos == 2)
                        {
                            zakaz_names[6] = dekor1;
                            zakaz_ceni[6] = cena1;
                        }
                        else if (Dop.pos == 3)
                        {
                            zakaz_names[6] = dekor2;
                            zakaz_ceni[6] = cena2;
                        }
                        return;
                }

                Console.Clear();
            }
        }
    }
}
