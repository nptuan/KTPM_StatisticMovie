using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie_TemplateMethod
{
    public class ScoresAndGenreOfMovie : StatisticMethod
    {
        private float ratingIndex { get; set; }
        private string genreIndex { get; set; }
        public ScoresAndGenreOfMovie(float RatingIndex, string GenreIndex)
        {
            ratingIndex = RatingIndex;
            genreIndex = GenreIndex;
        }
        public override bool Method1(Movie movie, float MaxScores)
        {
            return (movie._rating >= ratingIndex) && (movie._genre == genreIndex);
        }
    }
}