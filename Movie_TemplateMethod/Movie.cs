using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie_TemplateMethod
{
    public class Movie
    {
        public string _name { get; set; }
        public string _country { get; set; }
        public string _genre { get; set; }
        public float _rating { get; set; }
        public float _scores { get; set; }

        public Movie(string Name, string Country, string Genre, float Rating, float Scores)
        {
            _name = Name;
            _country = Country;
            _genre = Genre;
            _rating = Rating;
            _scores = Scores;
        }
    }
}