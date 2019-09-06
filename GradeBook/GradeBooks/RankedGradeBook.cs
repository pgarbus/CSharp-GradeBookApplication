﻿using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
  public class RankedGradeBook : BaseGradeBook
  {
    public RankedGradeBook(string name) : base(name)
    {
      _gradeBookType = GradeBookType.Ranked;
    }
  }
}