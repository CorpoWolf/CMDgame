using System;

namespace CMDgame
{
    class Gameplay
    {
        static string CharacterName = NameCheck();

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
                    Console.Write("XP: ");
                    BTS.Back();
                    continue;
                }
                else if (R.ToLower() == "Explore")
                {
                    Console.Write("Nothing here");
                    BTS.Back();
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
    }
}