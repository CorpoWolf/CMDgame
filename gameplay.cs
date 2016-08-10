using System;

namespace CMDgame
{
    class Gameplay
    {
        static string CharacterName()
        {

            Console.Write("What is the name of your character?: ");
            string Cname = Console.ReadLine();
            return (Cname);
        }

        public static void Continue1()
        {
            BTS.Clear();
            string name = CharacterName();
            while(true)
            {
                Console.WriteLine("Are you sure you want to use the name: " + name + "?" + "[Yes or No?] ");
                string YN = Console.ReadLine();
                if (YN.ToLower() == "yes")
                {
                    Adventure();
                    break;
                }
                else if (YN.ToLower() == "no")
                {
                    Continue1();
                    break;
                }
            }
        }

        public static void Adventure()
        {
            Console.WriteLine("Test complete");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}