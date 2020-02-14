using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {       
            
            var book = new Book("Scotts grade book.");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            
            var stats = book.GetStatistics();

            
            Console.WriteLine($"The average number is {stats.Average}.");
            Console.WriteLine($"The higher number is {stats.High}.");
            Console.WriteLine($"The lower number is {stats.Low}.");   
            
        }        
    }
}
