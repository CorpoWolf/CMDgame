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
            try
            {
                int test = Convert.ToInt32(ColorRS);
            }
            catch (FormatException)
            {
                Console.Write("It has to be an integer");
                BTS.ReWrite();
                Color();
            }
            int ColorRI = Convert.ToInt32(ColorRS);

            if ((ColorRI > 0) && (ColorRI <= 15))
            {
                Console.ForegroundColor = (ConsoleColor)ColorRI;
                BTS.Clear();
                MainMenu.TheMenu();
            }
            else
            {
                Console.WriteLine("That is not an option\ntry again");
                BTS.ReWrite();
                Color();
            }
        }
    }
}
