using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook: BaseGradeBook
    {
        public RankedGradeBook(string name): base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (this.Students.Count < 5) throw new InvalidOperationException();

            var grade = new Char();

           if (averageGrade >= 80)
            {
                grade = 'A';
            }
           else if (averageGrade >= 60)
            {
                grade = 'B';
            }
           else if (averageGrade >= 40)
            {
                grade = 'C';
            }
           else if (averageGrade >= 20)
            {
                grade = 'D';
            }
           else
            {
                grade = 'F';
            }
                
                           
            return grade;
        }
    }
}
