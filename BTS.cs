using System;

namespace CMDgame
{
    class BTS
    {
        public static void ReWrite()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1);
                ConsoleKeyInfo Continue = Console.ReadKey();
                if (Continue.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (Continue.Key != ConsoleKey.Enter)
                {
                    int pos = Console.CursorLeft; //Take the current cursor location
                    Console.SetCursorPosition(pos - 1, Console.CursorTop); //move it back 1 left
                    Console.Write(" "); //Write an empty space
                    Console.SetCursorPosition(pos - 1, Console.CursorTop); //Move it back 1 again
                }
            }
            Console.Clear();
        }

        public static void Gap()
        {
            Console.WriteLine();
        }

        public static void Clear()
        {
            Console.Clear();
        }
        public static void Enter()
        {
            Gap();
            Console.Write(": ");
        }

        public static void BackMM()
        {
            Gap();
            Console.Write("Press Enter to go back");
            BTS.ReWrite();
            MainMenu.MainOptions();
        }
        public static void Back()
        {
            Gap();
            Console.Write("Press Enter to go back");
            BTS.ReWrite();
        }
    }
}