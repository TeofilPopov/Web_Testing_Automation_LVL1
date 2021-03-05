using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLVL1.Animals
{
    public class Dog : Animal
    {
        public Dog(bool isFemale, string name, int age) 
            : base(isFemale, name, age)
        {
        }

        public override string AnimalSound => "Bau Bau";
    }
}
