using System;
using System.Data.Common;
/**/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess =0;
        int guesscount =0;

        
        while (guess!=number){

                Console.WriteLine("What's your guess?");
                guess = int.Parse(Console.ReadLine());
                guesscount++;

            if (guess>number){
                Console.WriteLine("Lower");
            }
            else if (guess<number){
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine($"Congrats you've guess it, you played {guesscount} times");
            }

        }



    }
}