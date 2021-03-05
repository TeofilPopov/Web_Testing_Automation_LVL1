using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLVL1.Animals
{
    public class Kitten : Animal
    {
        public Kitten(bool isFemale, string name, int age) 
            : base(isFemale, name, age)
        {
            isFemale = true;
        }

        public override string AnimalSound => "Mimimi";
    }
}
