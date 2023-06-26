using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CreatedDate { get; set; }
        public double UserRating { get; set; }
        public double ProRating { get; set; }
        public int NumTaken { get; set; }

        public Book(int id, string title, string author, string date, double userRating, double proRating, int numTaken)
        {
            Id = id;
            Title = title;
            Author = author;
            CreatedDate = date;
            UserRating = userRating;
            ProRating = proRating;
            NumTaken = numTaken;
        }


    }
}
