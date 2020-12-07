using PostgresHW.Classes;
using PostgresHW.Classes.MenuSettings;
using System;
using System.Text;

namespace PostgresHW
{

    /// <summary>
    ///     Оформити і здати
    /// </summary>
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            MenuSettings.Menu();
        }
    }
}
