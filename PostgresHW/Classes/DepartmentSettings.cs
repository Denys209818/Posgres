using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PostgresHW.Classes
{
    static class DepartmentSettings
    {
        public static Context c = new Context();
        public static int ReadNumber() 
        {
            int num = 0;
            while (true) 
            {
                MenuSettings.MenuSettings.ClearMiddle();
                 try
                 {
                    Console.SetCursorPosition(42, 10);
                    Console.Write("Ведіть Id: ");
                    string number = Console.ReadLine();
                    if (string.IsNullOrEmpty(number)) 
                    {
                        return -1;
                    }
                    num = int.Parse(number);
                    break;
                 }
                 catch 
                 {

                 }
            } 

            return num;
        }
        public static void AddToDataBase() 
        {
            MenuSettings.MenuSettings.ShowBorder();
            Console.SetCursorPosition(42, 10);
            Console.Write("Введіть назву: ");
            string name = Console.ReadLine();
            Department d = new Department();
            d.name = name;
            c.departments.Add(d);

            c.SaveChanges();
            Console.SetCursorPosition(58,14);
            Console.WriteLine("Додано!");
            Console.ReadKey();
        }
        public static void ReadAll() 
        {
            int counter = 0;
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                MenuSettings.MenuSettings.ShowBorder();

            while (keyInfo.Key != ConsoleKey.Enter) 
            {
                int a = 0;

                MenuSettings.MenuSettings.ClearMiddle();


            foreach (var item in c.departments.Skip(counter).Take(5)) 
            {
                    Console.SetCursorPosition(45, 10 + a++);
                Console.WriteLine("Id: " + item.Id + " Name: " + item.name);
            }
                Console.SetCursorPosition(45, 15);
                Console.WriteLine("<- Назад [ENTER] Вперед ->");
                keyInfo = Console.ReadKey();

                switch (keyInfo.Key) 
                {
                    case ConsoleKey.LeftArrow: 
                        {
                            if (counter > 0) 
                            {
                                counter -= 5;
                            }
                            break; 
                        }
                    case ConsoleKey.RightArrow: 
                        {
                            if (counter + 5 < c.departments.Count()) 
                            {
                                counter += 5;
                            }
                            break; 
                        }
                }
            }
        }
        public static void ReplaceElement() 
        {
            MenuSettings.MenuSettings.ShowBorder();

            Console.SetCursorPosition(42, 10);
            int Id = ReadNumber();
            if (Id == -1) { return; }

            Department dep = c.departments.Where(dep => dep.Id == Id).SingleOrDefault();

            if (dep != null)
            {
                 Console.SetCursorPosition(42, 11);
                Console.Write("Ведіть нову назву: ");
                string name = Console.ReadLine();
                dep.name = name;
                Console.SetCursorPosition(57, 14);
                Console.WriteLine("Змінено!");
                Console.ReadKey();

                c.SaveChanges();
            }
            else 
            {
                Console.SetCursorPosition(50, 14);
                Console.WriteLine("Елемента не знайдено!");
                Console.ReadKey();

            }
        }
        public static void DeleteElement()
        {
            MenuSettings.MenuSettings.ShowBorder();

            Console.SetCursorPosition(42, 10);

            int Id = ReadNumber();
            if (Id == -1) { return; }


            Department dep = c.departments.Where(dep => dep.Id == Id).SingleOrDefault();

            if (dep != null)
            {
                c.departments.Remove(dep);
                MenuSettings.MenuSettings.ShowBorder();

                Console.SetCursorPosition(56, 14);
                Console.WriteLine("Видалено!");
                Console.ReadKey();

                c.SaveChanges();
            }
            else
            {
                Console.SetCursorPosition(50, 14);
                Console.WriteLine("Елемента не знайдено!");
                Console.ReadKey();
            }
        }
    }
}
