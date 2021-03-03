using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpLVL1.Models
{
    public class Book
    {
        private double _price;
        private string _title;

        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;

            if (Regex.IsMatch(Author, @"^\d"))
            {
                throw new ArgumentException("The name cannot start with a digit");
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Title ist not valid");
                }
                _title = value;
            }
        }

        public string Author { get; set; }

        public virtual double Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid");
                }
                _price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("In the Library you can find:");
            sb.AppendLine();
            sb.AppendLine($"{Title} by {Author}");
            sb.AppendLine($"Price {Price:f1} Euro");
            return sb.ToString();
        }
    }
}
