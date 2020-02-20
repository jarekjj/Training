using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {       
            
            var book = new Book("Scotts grade book.");
           

            while (true)
            {
                System.Console.WriteLine("Enter grade. To quit eneter Q");
                var input = Console.ReadLine();

                if (input == "Q")
                {
                    break;
                }

                try 
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }

                catch(ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }

                catch(FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }

                finally
                {
                    System.Console.WriteLine("AWARIA");
                }

                
            }

            var stats = book.GetStatistics();

            
            Console.WriteLine($"The average number is {stats.Average:N1}.");
            Console.WriteLine($"The higher number is {stats.High}.");
            Console.WriteLine($"The lower number is {stats.Low}.");
            System.Console.WriteLine($"The letter grade is {stats.Letter}");   
            
        }        
    }
}
