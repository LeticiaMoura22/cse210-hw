using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your grade percentage?");
        int grade_percentage = int.Parse(Console.ReadLine());

        string letter ="";
        string plus_or_minus="";

        if (grade_percentage>=90){
            letter="A";
        }
        else if (grade_percentage>=80 && grade_percentage<90 ){
            letter="B";
        }
        else if (grade_percentage>=70 && grade_percentage <80) {
            letter="C";
        }
        else if (grade_percentage>=60 && grade_percentage<70){
            letter="D";
        }
        else{
            letter="F";
        }
        
        
        int last_digit = grade_percentage%10;

        if (last_digit<3){
            plus_or_minus="-";
        }
        else if (last_digit>=7){
            plus_or_minus="+";
        }
        else{
            plus_or_minus="";
        }


        if (letter =="A" || letter=="F" ){
            plus_or_minus="";

        }


        Console.WriteLine($"Your grade is: {letter}{plus_or_minus}");

        if (grade_percentage>=70){

            Console.WriteLine($"Congrats! You've passed :)");

        }
        else {
            Console.WriteLine($"Don't give up maybe next time!");

        }



    }
}