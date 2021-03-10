using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPractice
{
    class Book
    {
        private string title;
        public string author;
        public int pages;
        private string rating;

        public Book()
        {

        }

        public Book(string aTitle, string aAuthor, int aPages, string aRating)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            rating = aRating;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "PG" || value == "G" || value == "R")
                {
                    rating = value;
                }
                else
                {
                    rating = "Unknown";
                }
            }
        }

        public static void BookOwner(string name)
        {
            Console.WriteLine("The owner of this book is " + name);
        }
       
    }
}
