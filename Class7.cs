using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class Moviee : IComparable<Moviee>
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public Moviee()
        {

        }
        public Moviee(int MovieId, string MovieName)
        {
            this.MovieId = MovieId;
            this.MovieName = MovieName;
        }
        public int CompareTo(Moviee temp)
        {
            //if (this.MovieId < other.MovieId)
            //{
            //    return -1;
            //}
            //if (this.MovieId > other.MovieId)
            //{
            //    return 1;
            //}
            //return 0;
            return this.MovieName.CompareTo(temp.MovieName);
        }

        public override string ToString()
        {
            return $"{MovieId}\t{MovieName}";
        }
    }
    class Class7
    {
        static void Main(string[] args)
        {
            //SortedSet<int> intset = new SortedSet<int>();
            //intset.Add(10);
            //intset.Add(45);
            //intset.Add(33);
            //intset.Add(30);
            //intset.Add(12);
            //intset.Add(10);
            //foreach(int i in intset)
            //{
            //    Console.WriteLine(i);
            //}
            SortedSet<Moviee> moviesset = new SortedSet<Moviee>();

            moviesset.Add(new Moviee(5, "kiran"));
            moviesset.Add(new Moviee() { MovieId = 1, MovieName = "Laddu" });
            moviesset.Add(new Moviee() { MovieId = 3, MovieName = "sruthi" });
            moviesset.Add(new Moviee() { MovieId = 4, MovieName = "Ravi" });
            moviesset.Add(new Moviee() { MovieId = 2, MovieName = "sweety" });

            foreach(Moviee moviee in moviesset)
            {
                Console.WriteLine(moviee);
            }




        }
    }
}
