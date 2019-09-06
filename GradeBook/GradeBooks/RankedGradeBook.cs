using System;
using System.Linq;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
  public class RankedGradeBook : BaseGradeBook
  {
    public RankedGradeBook(string name) : base(name)
    {
      Type = GradeBookType.Ranked;
    }

    public override char GetLetterGrade(double averageGrade)
    {
      var minimum_number_of_students = 5;
      if (Students.Count < minimum_number_of_students)
      {
        throw InvalidOperationException($"Ranked-grading requires a minimum of {minimum_number_of_students} students to work");
      }
      var threshold = (int)Math.Ceiling(Students.Count * 0.2);
      var grades = Students.OrderByDescending(x => x.AverageGrade).Select(e => e.AverageGrade).ToList();
      if (grades[threshold - 1] <= averageGrade)
      {
        return 'A';
      }
      else if (grades[threshold*2 - 1] <= averageGrade)
      {
        return 'B';
      }
      else if (grades[threshold*3 - 1] <= averageGrade)
      {
        return 'C';
      }
      else if (grades[threshold*4 - 1] <= averageGrade)
      {
        return 'D';
      }
      return 'F';
    }
  }
}