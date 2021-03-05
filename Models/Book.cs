using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpLVL1.Models
{
    public class Book
    {
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;

            if (Regex.IsMatch(Author, @"^\d"))
            {
                throw new ArgumentException("The name cannot start with a digit");
            }

            if (Title.Length<3)
            {
                throw new ArgumentException("The title should contain more than 3 symbols");
            }

            if (Price <= 0)
            {
                throw new ArgumentException("The price can not be negative");
            }
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public virtual double Price { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(string.Format("Title {0}", Title));
            sb.AppendLine();
            sb.Append(string.Format("Author {0}", Author));
            sb.AppendLine();
            sb.Append($"Price {Price:f2} Euro");
            //var alternativeString = $"Title {Title} {Environment.NewLine}" +
            //                        $"Author {Author}{Environment.NewLine} Price {Price:f2} Euro";
            return sb.ToString(); 
        }
    }

    
}
