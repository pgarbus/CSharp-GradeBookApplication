using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
  public class StandardGradeBook : BaseGradeBook
  {
    private GradeBookType _gradeBookType;

    public StandardGradeBook(string name) : base(name)
    {
      _gradeBookType = GradeBookType.Standard;
    }
  }
}