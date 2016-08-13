using System;

namespace CMDgame
{
    class Gameplay
    {
        static string CharacterName = NameCheck();

        public static string NameCheck()
        {
            BTS.Clear();
            Console.Write("What name would you like: ");
            string R = Console.ReadLine();

            while(true)
            {
                if (R.Length > 0)
                {
                    foreach (char letter in R)
                    {
                        if (char.IsLetter(letter))
                        {
                        }
                        else
                        {
                            Console.WriteLine("Can only be letters");
                            BTS.ReWrite();
                            NameCheck();
                        }
                    }
                    break;
                }
                else if (R.Length < 1)
                {
                    Console.WriteLine("Must contain some letters");
                    BTS.ReWrite();
                    NameCheck();
                }
            }

            BTS.Clear();
            System.Console.WriteLine("Are you sure you want to use the name: " + R + "?" + "[Yes or No]");
            while(true)
            {
                String R2 = Console.ReadLine();
                if (R2.ToLower() == "yes")
                {
                    break;
                }
                else if (R2.ToLower() == "no")
                {
                    NameCheck();
                }
            }
            return R;
        }

        public static void Adventure()
        {
            BTS.Clear();
            Console.WriteLine("Well hello, " + CharacterName);
            Console.Read();
        }
    }
}