using System;
using System.Collections.Generic;
using System.Text;

namespace NewGradeCalc
{
    class Letter
    {
        public char LetterGrade { get; set; }
        public Letter(decimal finalAverage)
        {
            LetterGrade = GetLetter(finalAverage);
        }
        public char GetLetter(decimal finalAverage)
        {
            char letterGrade;
            if (finalAverage >= 90)
            {
                letterGrade = 'A';
            }
            else if (finalAverage < 90 && finalAverage >= 80)
            {
                letterGrade = 'B';
            }
            else if (finalAverage < 80 && finalAverage >= 70)
            {
                letterGrade = 'C';
            }
            else if (finalAverage < 70 && finalAverage >= 60)
            {
                letterGrade = 'D';
            }
            else
            { letterGrade = 'F'; }
            return letterGrade;
        }
    }
}
