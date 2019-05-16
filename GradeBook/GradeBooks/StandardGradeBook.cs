using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isweighted) : base(name,isweighted)
        {
            Type = GradeBookType.Standard;
        }

 
    }
}
