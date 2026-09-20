using Student_Grade_Calculator;

namespace NewGradeCalc
{
    class StudentGradeCalculator
    {
        static void Main()
        {
            Student student = new Student();
            student.Name = student.GetName();
            student.Name = student.ValidateName(student.Name);

            Score score = new Score();

            score.Average = new Score().GetScores();
            Letter letter = new Letter(score.Average);
            student.DisplayResults(student.Name, score.Average, letter.LetterGrade);

            //decimal average = new Score().GetScores();
            //Student.LetterGrade = new Letter(average).LetterGrade;
            //Student.DisplayResults();
        }


    }
}
