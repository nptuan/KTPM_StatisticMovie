using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie_TemplateMethod
{
    public class RatingOfMovie : StatisticMethod
    {
        private float ratingIndex { get; set; }
        public RatingOfMovie(float RatingIndex)
        {
            ratingIndex = RatingIndex;
        }
        public override bool Method1(Movie movie, float MaxScores)
        {
            return (movie._rating >= ratingIndex);
        }
    }
}