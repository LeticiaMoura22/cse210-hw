using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);


        Console.WriteLine("What is your guess");
        int guess = Console.Read();

        while (guess != magicNumber)
        {
            if (guess>magicNumber)
            {
                Console.WriteLine("Lower");

            }
            else (guess<magicNumber)
            {
                Console.WriteLine("Higher");
            }
        }
        Console.Write("You guess it!");



    }
}