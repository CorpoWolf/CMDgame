using System;

namespace CMDgame
{
   class MainMenu
    {
        public static void TheMenu()
        {
            IntroMenu();
            MainOptions();
        }

        static void IntroMenu()
        {
            Console.WriteLine("Welcome to this text adventure cmd game");
            BTS.ReWrite();
            Console.WriteLine("Enjoy ;)");
            BTS.ReWrite();
        }

        public static void MainOptions()
        {
            Console.Clear();
            string R1 = "start";
            string R2 = "learn c#";
            string R3 = "about";
            string R4 = "quit";

            Console.WriteLine(R1);
            Console.WriteLine(R2);
            Console.WriteLine(R3);
            Console.WriteLine(R4);

            BTS.Gap();

            Console.Write(":");
            string MenuResponse = Console.ReadLine();

            if (MenuResponse.ToLower() == R1)
            {
                MenuStart();
            }
            else if (MenuResponse.ToLower() == R2)
            {
                Menulearn();
            }
            else if (MenuResponse.ToLower() == R3)
            {
                MenuAbout();
            }
            else if (MenuResponse.ToLower() == R4)
            {
                Environment.Exit(0);
            }
                Console.WriteLine("Try again");
                BTS.ReWrite();
                MainOptions();
        }

        static void MenuStart()
        {
            BTS.Clear();
            Gameplay.CharacterName();
        }

        static void Menulearn()
        {
            BTS.Clear();
            Console.WriteLine("C# Notes: bit.ly/JeeCsharp");
            Console.WriteLine("C# tutorials: bit.ly/JeeCsharpPlay");
            BTS.BackMM();
        }

        static void MenuAbout()
        {
            BTS.Clear();
            string Version = "0.2";
            Console.WriteLine("Current version: " + Version);
            Console.WriteLine("Created by Gavin");
            Console.WriteLine("This is an early development many features don't work");
            BTS.BackMM();
        }
    }
}