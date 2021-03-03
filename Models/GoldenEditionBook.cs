using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSharpLVL1.Models
{
    public class GoldenEditionBook :Book
    {
        public GoldenEditionBook(string title, string author, double price) : base(title, author, price)
        {
        }

        public override double Price
        {
            get => base.Price*1.3;
            set => base.Price = value;
        }
    }
}
