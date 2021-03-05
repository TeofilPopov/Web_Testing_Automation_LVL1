using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLVL1.Animals
{
    public class Cat : Animal
    {
        public Cat(bool isFemale, string name, int age) : base(isFemale, name, age)
        {
        }

        public override string AnimalSound => "Miau";
    }
}
