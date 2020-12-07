using System;
using System.Collections.Generic;
using System.Text;

namespace PostgresHW.Classes.MenuSettings
{
    static class MenuSettings
    {
        public static void Menu()
        {
            while (true) 
            {
                Console.Clear();
                int counter = 1;
                ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                while (keyInfo.Key != ConsoleKey.Enter)
            {
                ClearMiddle();
                ShowBorder();
                if (counter == 1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.SetCursorPosition(45, 10);
                Console.WriteLine("1. Додати елемент");
                Console.BackgroundColor = ConsoleColor.Black;

                if (counter == 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.SetCursorPosition(45, 11);
                Console.WriteLine("2. Показати усі елементи");
                Console.BackgroundColor = ConsoleColor.Black;

                if (counter == 3)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.SetCursorPosition(45, 12);
                Console.WriteLine("3. Видалити елемент");
                Console.BackgroundColor = ConsoleColor.Black;

                if (counter == 4)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.SetCursorPosition(45, 13);
                Console.WriteLine("4. Редагувати елемент");
                Console.BackgroundColor = ConsoleColor.Black;

                if (counter == 5)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.SetCursorPosition(45, 14);
                Console.WriteLine("5. Вийти");
                Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(0, 0);

                    keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (counter > 1)
                            {
                                counter--;
                            }
                            else
                            {
                                counter = 5;
                            }
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (counter < 5)
                            {
                                counter++;
                            }
                            else
                            {
                                counter = 1;
                            }
                            break;
                        }
                }
            }
                Console.Clear();
                switch (counter) 
            {
                case 1: { DepartmentSettings.AddToDataBase(); break; }
                case 2: { DepartmentSettings.ReadAll(); break; }
                case 3: { DepartmentSettings.DeleteElement(); break; }
                case 4: { DepartmentSettings.ReplaceElement(); break; }
                case 5: { return; }
            }
            }
        }

        public static void ShowBorder() 
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 7; i++) 
            {
                Console.SetCursorPosition(40, 9+i);
                Console.WriteLine("@");
            }

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(80, 9 + i);
                Console.WriteLine("@");
            }

            for (int i = 40; i <= 80; i++) 
            {
                Console.SetCursorPosition(i, 8);
                Console.WriteLine("@");
            }
            for (int i = 40; i <= 80; i++)
            {
                Console.SetCursorPosition(i, 16);
                Console.WriteLine("@");
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.BackgroundColor = ConsoleColor.Black;

        }

        public static void ClearMiddle() 
        {
            for (int y = 0; y < 6; y++) 
            {
                for (int i = 41; i < 80; i++) 
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(i, 10 + y);
                    Console.WriteLine(" ");
                }
            }

        }
    }
}
