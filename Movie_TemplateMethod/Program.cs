using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieStatistic m = new MovieStatistic();
            m.InitList();
            Console.WriteLine(m.Count());
            StatisticMethod me = new ChildrenGenre();
            m.ChangeMethod(me);
            Console.WriteLine(m.Count());
            me = new HighestScoresMovie();
            m.ChangeMethod(me);
            Console.WriteLine(m.Count());
            me = new ChildrenGenre();
            m.ChangeMethod(me);
            Console.WriteLine(m.Count());
            me = new ChildrenGenre();
            m.ChangeMethod(me);
            Console.WriteLine(m.Count());
        }
    }
}
