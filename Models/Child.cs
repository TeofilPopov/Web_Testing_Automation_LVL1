using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLVL1.Models
{
    public class Child : Person
    {
        public Child(string name1, int age) 
            : base(name1, age)
        {
        }

        public override int Age
        {
            get => base.Age;
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Congrats you are adult");
                }

                base.Age = value;
            }
        }
    }
}
