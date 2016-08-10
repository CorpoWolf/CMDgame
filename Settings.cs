using System;


namespace CMDgame
{
    class Settings
    {
        public static void Color()
        {
            BTS.Clear();
            Console.Write("What text color do you want?: ");
            string ColorRS = Console.ReadLine();
            int ColorRI = Convert.ToInt32(ColorRS);
            Console.ForegroundColor = (ConsoleColor)ColorRI;
            BTS.Clear();
            MainMenu.TheMenu();
        }
    }
}
