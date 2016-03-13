using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie_TemplateMethod
{
    public class MovieStatistic
    {
        public List<Movie> list = new List<Movie>();
        public StatisticMethod method = new VietnamMovie();

        public void ChangeMethod(StatisticMethod Method)
        {
            method = Method;
        }
        public void InitList()
        {
            Movie movie = new Movie("Em La Ba Noi Cua Anh","Vietnam", "Non Fiction", 10.1f, 7.5f);
            list.Add(movie);
            movie = new Movie("Deadpool", "US", "Fiction", 20.1f, 8.9f);
            list.Add(movie);
            movie = new Movie("My Nhan Ngu", "China", "Fiction", 18.1f, 8.5f);
            list.Add(movie);
            movie = new Movie("Inside Out", "US", "Children", 19.4f, 8.9f);
            list.Add(movie);
        }
        private float maxScores()
        {
            float max = list[0]._scores;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i]._scores >= max)
                    max = list[i]._scores;
            }
            return max;
        }
        public int Count()
        {
            int count = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                if (method.Method1(list[i], maxScores()))
                    count++;
            }
            return count;
        }
    }
}