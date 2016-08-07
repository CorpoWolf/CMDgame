using System;

namespace CMDgame
{
    class Gameplay
    {
        public static string CharacterName()
        {
            Console.Write("What is the name of your character?: ");
            string Cname = Console.ReadLine();
            YesNoCharacter();
            return (Cname);
        }

        public static void YesNoCharacter()
        {
            BTS.Clear();
            Console.WriteLine("Are you sure you want to use the name " + CharacterName() + "Yes or No?");
            string YN = Console.ReadLine();
            if (YN.ToLower() == "yes")
            {
                Adventure();
            }
            else if (YN.ToLower() == "no")
            {
                CharacterName();
            }
            YesNoCharacter();
        }

        public static void Adventure()
        {
            
        }
    }
}
