using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;


namespace GradeBook.GradeBooks
{
    public class StandardGradeBook: BaseGradeBook
    {
        public StandardGradeBook(string name): base(name)
        {
            var gradeBook = new BaseGradeBook(name);
            gradeBook.Type = GradeBookType.Standard;
        }
    }
}
