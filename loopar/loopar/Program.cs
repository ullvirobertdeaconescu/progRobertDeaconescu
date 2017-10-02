using System;

namespace loopar
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            char forsokigen = "y";
            while (forsokigen == "y")
            {
                Console.WriteLine("När jag är ung...");
                string svar = Console.ReadLine();

                if (svar.ToLower() == "människan")
                {
                    Console.WriteLine("rätt!");
                    break;
                }
                else
                {
                    Console.WriteLine("vill du forsoka igen?");
                    forsokigen = Console.ReadLine()[0];
                }    
           }
        }   

    }
}
