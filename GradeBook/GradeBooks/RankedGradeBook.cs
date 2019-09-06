using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
  public class RankedGradeBook : BaseGradeBook
  {
    public StandardGradeBook(string name) : base(name)
    {
      _gradeBookType = GradeBookType.Ranked;
    }
  }
}