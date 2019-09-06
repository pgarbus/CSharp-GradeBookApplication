using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
  public class RankedGradeBook : BaseGradeBook
  {
    public GradeBookType _gradeBookType;
    public RankedGradeBook(string name) : base(name)
    {
      _gradeBookType = GradeBookType.Ranked;
    }
  }
}