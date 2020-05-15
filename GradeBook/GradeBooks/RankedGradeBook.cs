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
            var gradeBook = new BaseGradeBook(name);
            gradeBook.Type = GradeBookType.Ranked;
        }
    }
}
