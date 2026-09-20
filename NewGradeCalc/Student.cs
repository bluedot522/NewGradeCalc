using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Student_Grade_Calculator
{
    public class Student
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string GetName()
        {
            WriteLine("Welcome! Please enter student name to begin. >> ");
            string name = Console.ReadLine();
            return name;
        }
        public string ValidateName(string name)
        {

            while (!Regex.IsMatch(name, @"[a-zA-Z\s]$"))
            {
                WriteLine("Please enter a name. (Letters only.)");
                name = Console.ReadLine();
            }
            return name;
        }
        public void DisplayResults(string name, decimal average, char letterGrade)
        {
            WriteLine("{0}'s grade is an average of {1:F2}% and a grade of {2}.", name, average, letterGrade);
        }
    }
}