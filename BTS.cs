using System;

namespace CMDgame
{
    class BTS
    {
        /// <summary>
        /// Does a readline, if enter is pressed continue, if not remove what was typed.
        /// </summary>
        public static void ReWrite()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(7);
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

        /// <summary>
        /// Create an empty WriteLine
        /// </summary>
        public static void Gap()
        {
            Console.WriteLine();
        }

        /// <summary>
        /// Does a Console clear
        /// </summary>
        public static void Clear()
        {
            Console.Clear();
        }

        /// <summary>
        /// Creates a readline field for the user
        /// </summary>
        public static void Enter()
        {
            Gap();
            Console.Write(": ");
        }

        /// <summary>
        /// Goes back to the main menu.
        /// </summary>
        public static void BackMM()
        {
            Gap();
            Console.Write("Press Enter to go back");
            BTS.ReWrite();
            MainMenu.MainOptions();
        }

        /// <summary>
        /// Writes a string with gap and ReWrite.
        /// </summary>
        public static void Back()
        {
            Gap();
            Console.Write("Press Enter to go back");
            BTS.ReWrite();
        }
    }
}