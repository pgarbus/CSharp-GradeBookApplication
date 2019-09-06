using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
  public class StandardGradeBook : BaseGradeBook
  
  {

    public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
    {
      IsWeighted = isWeighted;
      Type = GradeBookType.Standard;
    }
  }
}