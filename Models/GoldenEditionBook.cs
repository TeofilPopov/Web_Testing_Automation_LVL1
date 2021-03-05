using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLVL1.Models
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, double price):base(title, author, price)
        {
            Price += 0.3 * price;
        }
    }
}
