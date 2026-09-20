using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace NewGradeCalc
{
    class Score
    {
        public decimal Average { get; set; }
        
        public decimal Calc(decimal totalScore, int scoreCount)
        {
            decimal finalAverage;
            if (scoreCount == 0)
            {
                Average = 0;
            }
            else
            { Average = totalScore / scoreCount; }

            return Average;
        }

        public decimal GetScores()
        {
            string scoreString = "";
            int scoreCount = 0;
            decimal totalScore = 0.00m;

            WriteLine("Enter a score or X to quit.");
            string input = ReadLine();
            while (input != "X" && input != "x")
            {
                // Validate Scores
                if (Decimal.TryParse(input, out decimal value))
                {
                    decimal score = Convert.ToDecimal(input);
                    if (score <= 100.0m && score >= 0.0m)
                    {
                        totalScore += score;
                        scoreCount += 1;
                        scoreString += Convert.ToString(score) + " ";
                    }
                    else
                    {
                        WriteLine("Please enter a number between 0 and 100.");
                        WriteLine(" ");
                    }
                }
                else
                {
                    WriteLine("Please enter a number.");
                    WriteLine(" ");
                }
                WriteLine("Enter a score or X to quit.");
                input = ReadLine();

            }
            if (scoreCount > 0)
            { WriteLine("Scores entered: " + scoreString); }

            else
            { WriteLine("Scores entered: 0"); }

            return Calc(totalScore, scoreCount);
        }

    }
}
