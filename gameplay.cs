using System;

namespace CMDgame
{
    class Gameplay
    {
        static string CharacterName = Sure1();

        public static string Sure1()
        {
            BTS.Clear();
            Console.Write("What name would you like: ");
            string R = Console.ReadLine();
            BTS.Clear();
            System.Console.WriteLine("Are you sure you want to use the name: " + R + "?" + "[Yes or No]");
            while(true)
            {
                String R2 = Console.ReadLine();
                if (R2.ToLower() == "yes")
                {
                    return R;
                }
                else if (R2.ToLower() == "no")
                {
                    Sure1();
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