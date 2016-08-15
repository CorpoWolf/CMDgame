using System;

namespace CMDgame
{
    class Gameplay
    {
        static string CharacterName = NameCheck();

        public static string NameCheck()
        {
            string R = ""; //Creat the string with an empty string value.

            while(true) //Runs until a return is made.
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
                        break; //When the foreach is broken out of break out of the main while loop.
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

        public static void Adventure()
        {
            BTS.Clear();
            Console.WriteLine("Well hello, " + CharacterName);
            Console.Read();
        }
    }
}