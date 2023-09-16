using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        string letterSign = "";
        Console.Write("What is your grade percentage (Ex. 90 or 85 or 64)? ");
         int gradePercentage = int.Parse(Console.ReadLine());

        if (gradePercentage >= 70)
        {
            if (gradePercentage >= 90)
            {
                letter = "A";
                //if (gradePercentage >= 93)
                //{
                    //Console.WriteLine("Your grade is an A.");
                    //letter = "A";
                //}
                if (gradePercentage < 93)
                { 
                    letterSign = "-";
                    //letter = "A-";

                    //Console.WriteLine("Your grade is an A-.");
                }

            }
            else if (gradePercentage < 90 && gradePercentage >= 80)
            {
                letter = "B";
                if (gradePercentage >= 87)
                {
                    letterSign = "+";
                    //letter = "B+";
                    //Console.WriteLine("Your grade is an B+.");
                }
                //else if (gradePercentage < 87 && gradePercentage >= 83)
                //{

                    //letter = "B";
                    ////Console.WriteLine("Your grade is an B.");
                //}
                else if  (gradePercentage < 83)
                {
                    letterSign = "-";
                    //letter = "B-";
                    //Console.WriteLine("Your grade is an B-.");
                }
            }
            else if (gradePercentage < 80 && gradePercentage >= 70)
            {
                letter = "C";
                if (gradePercentage >= 77)
                {
                    letterSign = "+";
                    //letter = "C+";
                    //Console.WriteLine("Your grade is an C+.");
                }
                //else if (gradePercentage < 77 && gradePercentage >= 73)
                //{
                    
                    //letter= "C";
                    
                    //Console.WriteLine("Your grade is an C.");
                //}
                else if (gradePercentage < 73)
                {
                    letterSign = "-";
                    //letter = "C-";
                    
                    //Console.WriteLine("Your grade is an C-.");
                }
            }
            Console.WriteLine("You are passing the course!");
        }
        else
        {
            Console.WriteLine("You are failing the course, you can do it! You can improve!");
            if (gradePercentage < 70 && gradePercentage >= 60)
            {
                letter = "D";
                if (gradePercentage >= 67)
                {
                    letterSign = "+";
                    //letter = "D+";
                    
                    //Console.WriteLine("Your grade is an D+.");
                }
                //else if (gradePercentage < 67 && gradePercentage >= 63)
                //{
                    
                    //letter = "D";
                    
                    //Console.WriteLine("Your grade is an D.");
                //}
                else if (gradePercentage < 63)
                {
                    letterSign = "-";
                    //letter = "D-"
                    
                    //Console.WriteLine("Your grade is an D-.");
                }
            }
            else
            {
                letter = "F";
                //Console.WriteLine("Your grade is an F.");
            }
        }
        Console.WriteLine($"Youre grade is a {letter}{letterSign}");
    }   
}