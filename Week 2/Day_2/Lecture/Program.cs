using System;
using System.Collections.Generic;
using System.Linq;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie> {
            new Movie("Blood Diamond", "Leonardo DiCaprio", 8, 2006),
            new Movie("The Departed", "Leonardo DiCaprio", 8.5, 2006),
            new Movie("Gladiator", "Russell Crowe", 8.5, 2000),
            new Movie("A Beautiful Mind", "Russell Crowe", 8.2, 2001),
            new Movie("Good Will Hunting", "Matt Damon", 8.3, 1997),
            new Movie("The Martian", "Matt Damon", 8, 2015),
        };

        List<Actor> actors = new List<Actor> {
            new Actor { FullName = "Matt Damon", Age = 48 },
            new Actor { FullName = "Leonardo DiCaprio", Age = 44 },
        };
        Movie isThereGlad = movies.FirstOrDefault(movie => movie.Title=="Gladiator");
        Movie def = movies.FirstOrDefault(movie => movie.Title=="abc");
        Movie oldest = movies.FirstOrDefault(m => m.Year== movies.Min(movie => movie.Year));
        List<Movie> orderedByTitle = movies.OrderByDescending(mov => mov.Title).ToList();
        List<Movie> allLeoD = movies.Where(movie => movie.LeadActor=="Leonardo DiCaprio").ToList();
        List<Movie> something = movies.Where(m => m.LeadActor=="Russell Crowe" && m.Year<=2000).ToList();
        PrintEach(something);
        }

        public static void PrintEach(IEnumerable<dynamic> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
