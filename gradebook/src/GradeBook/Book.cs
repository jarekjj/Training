using System.Collections.Generic;
using System;

namespace GradeBook
{
   class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var highGrade = double.MinValue;  
            var lowGrade = double.MaxValue;                       
            var result = 0.0;
            foreach(var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            } 

            result /= grades.Count;

            Console.WriteLine($"The average number is {result:N1}.");
            Console.WriteLine($"The higher number is {highGrade}.");
            Console.WriteLine($"The lower number is {lowGrade}.");   
        }
        List<double> grades;  
        private string name;      
    }
}