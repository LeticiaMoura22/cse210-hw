using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insert your grade percentage:");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        string letter = "";


        if (gradePercentage >= 90)
        {
            //Console.Write("A");
            letter= "A";
        }
        else if (gradePercentage >= 80)
        {
            //Console.Write("B");   
            letter="B";
        }
        else if ( gradePercentage >= 70)
        {
            //Console.Write("C");
            letter="C";
        }
        else if (gradePercentage >= 60)
        {
            //Console.Write("D");
            letter="C";
        }
        else
        {
            //Console.Write("F");
            letter="F";

        };

        Console.WriteLine($"Your final grade is {letter}");

        //to skip a line in c# use \r ( r didn't worked for me) and \n

        if (gradePercentage >= 70)
        //if (letter =="C"||letter=="B"||letter=="A")
        {
            Console.WriteLine("Congrats!! You've passed this course");
        }
        else
        {
            Console.WriteLine("Not this time!! Try it again i'll suceed");
        }
    }
}