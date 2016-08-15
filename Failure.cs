////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// This is a past fail which caused the function to create a new string each time the function was recalled.                                                                  //
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//public static string NameCheck()
//{
//    BTS.Clear();
//    Console.Write("What name would you like: ");
//    string R = Console.ReadLine();
//
//    while (true)
//    {
//        if (R.Length > 0)
//        {
//            foreach (char letter in R)
//            {
//                if (char.IsLetter(letter))
//                {
//                }
//                else
//                {
//                    Console.WriteLine("Can only be letters");
//                    BTS.ReWrite();
//                    NameCheck();
//                }
//            }
//            break;
//        }
//        else if (R.Length < 1)
//        {
//            Console.WriteLine("Must contain some letters");
//            BTS.ReWrite();
//            NameCheck();
//        }
//    }
//
//    BTS.Clear();
//    System.Console.WriteLine("Are you sure you want to use the name: " + R + "?" + "[Yes or No]");
//    while (true)
//    {
//        String R2 = Console.ReadLine();
//        if (R2.ToLower() == "yes")
//        {
//            break;
//        }
//        else if (R2.ToLower() == "no")
//        {
//            NameCheck();
//        }
//    }
//    return R;
//}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// This has a bug in which if a number was typed it would still continue to the [Yes / No] question.                                                                          //
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//public static string NameCheck()
//{
//    string R = "";
//
//    while (true)
//    {
//        BTS.Clear();
//        Console.Write("What name would you like: ");
//        R = Console.ReadLine();
//        if (R.Length > 0)
//        {
//            foreach (char letter in R)
//            {
//                if (char.IsLetter(letter))
//                {
//                }
//                else
//                {
//                    Console.WriteLine("Can only be letters");
//                    BTS.ReWrite();
//                    continue;
//                }
//            }
//            BTS.Clear();
//            System.Console.WriteLine("Are you sure you want to use the name: " + R + "?" + "[Yes or No]");
//            while (true)
//            {
//                String R2 = Console.ReadLine();
//                if (R2.ToLower() == "yes")
//                {
//                    return R;
//                }
//                else if (R2.ToLower() == "no")
//                {
//                    break;
//                }
//            }
//        }
//        else if (R.Length < 1)
//        {
//            Console.WriteLine("Must contain some letters");
//            BTS.ReWrite();
//            continue;
//        }
//    }
//}