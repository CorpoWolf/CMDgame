using System;

namespace CMDgame
{
    class Gameplay
    {
        public static void Adventure()
        {
            Console.WriteLine("Let us begin " + Continue1()); //Has the program run Continue1() before.
        }

        public static string Continue1() 
        {
            BTS.Clear();
            string name = CharacterName(); //Has the program run CharacterName() before.
            while (true)
            {
                Console.WriteLine("Are you sure you want to use the name: " + name + "?" + "[Yes or No?] ");
                string YN = Console.ReadLine();
                if (YN.ToLower() == "yes")
                {
                    return name;
                }
                else if (YN.ToLower() == "no")
                {
                    Continue1();
                    return null;
                }
                return null;
            }
        }

        static string CharacterName()
        {
            Console.Write("What is the name of your character?: ");
            string Cname = Console.ReadLine();
            return (Cname);
        }
    }
}