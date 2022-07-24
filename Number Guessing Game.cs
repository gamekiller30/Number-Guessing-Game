using System;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine(i);
            }



            Console.WriteLine("Press any key to continue");
            Console.ReadKey();


            Random random = new Random();
            int Randomnumber = random.Next(0, 100);
            Console.WriteLine("Guess the number (only Integers between 0 and 100 are valid):");
            int Guessnumber;




            do
            {

                Guessnumber = int.Parse(Console.ReadLine());

                if (Guessnumber == Randomnumber)
                {

                    Console.WriteLine("Congrats you guessed the right number. It was:  {0}", Randomnumber);
                    break;


                }
                else if (Guessnumber > Randomnumber)

                {
                    Console.WriteLine("Your number is too high");

                }
                else if (Guessnumber < Randomnumber)

                {
                    Console.WriteLine("Your number is too low");

                }


            } while (Guessnumber != Randomnumber);



            Console.ReadKey();

        }
    }
}
