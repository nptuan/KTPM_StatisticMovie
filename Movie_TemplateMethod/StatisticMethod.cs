using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie_TemplateMethod
{
    public abstract class StatisticMethod
    {
        public abstract bool Method1(Movie movie, float MaxScores);
    }
}