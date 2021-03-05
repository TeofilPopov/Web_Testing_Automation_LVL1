using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLVL1.Animals
{
    class Tomcat : Animal
    {
        public Tomcat(bool isFemale, string name, int age) 
            : base(isFemale, name, age)
        {
            isFemale = false;
        }

        public override string AnimalSound => "Roah";
    }
}
