using System;

class Program {
    public static void Main (string[] args) {
        Random randomGenerator = new Random();
        int Number = randomGenerator.Next(1,101);
        int guess =0;
            while (guess != Number)
            {
                Console.WriteLine("What is your guess");
                guess = int.Parse(Console.ReadLine());

                if (guess>Number)
                    {
                        Console.WriteLine("Lower");
                    }
                else if (guess< Number)
                    {
                        Console.WriteLine("Higher");
                    }
                else
                {
                    Console.Write("You guess it!");
                }
            }
        
    }
}