using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie_TemplateMethod
{
    public class ChildrenGenre : StatisticMethod
    {
        public override bool Method1(Movie movie, float MaxScores)
        {
            return (movie._genre == "Children");
        }
    }
}