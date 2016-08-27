using System;

namespace CMDgame
{
    class Gameplay
    {
        static string CharacterName = NameCheck();
        static int CharacterLVL = 0;
        static int CharacterXP = 0;

        public static void Adventure()
        {
            BTS.Clear();
            Console.WriteLine("Well hello, " + CharacterName);
            BTS.ReWrite();
            AdventureMenu();
        }

        /// <summary>
        /// Name set function, letters only, must be 1 letter
        /// </summary>
        public static string NameCheck()
        {
            string R = ""; //Creat the string with an empty string value.

            while (true) //Runs until a return is made.
            {
                BTS.Clear();
                Console.Write("What name would you like: ");
                R = Console.ReadLine(); //Sets a new value for the R string.
                if (R.Length > 0) //if more than 0 characters are typed.
                {
                    foreach (char letter in R) //foreach character in the R string
                    {
                        if (char.IsLetter(letter)) //If each character is the R string is a letter.
                        {
                        }
                        else
                        {
                            Console.WriteLine("Can only be letters");
                            BTS.ReWrite();
                            break; //breaks out of the foreach
                        }
                        BTS.Clear();
                        System.Console.WriteLine("Are you sure you want to use the name: " + R + "?" + "[Yes or No]");
                        while (true)
                        {
                            String R2 = Console.ReadLine();
                            if (R2.ToLower() == "yes")
                            {
                                return R; //Return string R.
                            }
                            else if (R2.ToLower() == "no")
                            {
                                break; //breaks from this while loop
                            }
                        }
                        break; //breaks out of foreach
                    }
                }
                else if (R.Length < 1) //If less than 1 character is typed.
                {
                    Console.WriteLine("Must contain some letters");
                    BTS.ReWrite();
                    continue; //Restart the while loop.
                }
            }
        }

        /// <summary>
        /// The menu for adventuring
        /// </summary>
        public static void AdventureMenu()
        {
            string R = "";

            while (true)
            {
                BTS.Clear();
                Console.WriteLine("Character");
                Console.WriteLine("Explore");
                Console.WriteLine("Quit");

                BTS.Enter();
                R = Console.ReadLine();

                if (R.ToLower() == "character")
                {
                    BTS.Clear();

                    while(true)
                    {
                        if (CharacterXP >= 100)
                        {
                            CharacterLVL++;
                            for (int A = 1; A <= 100; A++)
                            {
                                CharacterXP--;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.Write("level: "+ CharacterLVL + " XP: "+ CharacterXP);
                    BTS.Back();
                    continue;
                }
                else if (R.ToLower() == "explore")
                {
                    Explore();
                    continue;
                }
                else if (R.ToLower() == "quit")
                {
                    Environment.Exit(0);
                }
                Console.WriteLine("Try again");
                BTS.ReWrite();
            }
        }
        /// <summary>
        /// The messages for beginning your adventure.
        /// </summary>
        static void BEx()
        {
            BTS.Clear();
            Console.WriteLine("Welcome to the adventure " + CharacterName + ".");
            BTS.ReWrite();
            Console.WriteLine("You're adventure is that of a C# programmer, because no one else could give me a real idea for one.");
            BTS.ReWrite();
            Console.WriteLine("Now the adventure begins!");
            System.Threading.Thread.Sleep(800);
            Console.WriteLine("Press enter once more to begin");
        }

        /// <summary>
        /// The adventure
        /// </summary>
        static void Explore()
        {
            while ((CharacterLVL <= 0) || (CharacterXP <= 0))
            {
                BEx();
                BTS.ReWrite();
                break;
            }
            BTS.Clear();

            ConsoleColor B = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press ESC to go back!");
            Console.ForegroundColor = B;
            while (true)
            {
                Console.WriteLine("Press space to gain 10 XP!");
                ConsoleKeyInfo Waka = Console.ReadKey();
                if (Waka.Key == ConsoleKey.Spacebar)
                {
                    for (int A = 1; A <= 10; A++)
                    {
                        CharacterXP++;
                    }
                }
                else if (Waka.Key == ConsoleKey.Escape)
                {
                    AdventureMenu();
                }
                else
                {
                    Console.WriteLine("M8, you pressed the wrong button.");
                    BTS.ReWrite();
                }
            }

        }
    }
}