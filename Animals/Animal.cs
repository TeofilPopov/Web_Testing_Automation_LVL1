using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLVL1.Animals
{
    public abstract class Animal
    {
        private string _name;
        private int _age;

        protected Animal(bool isFemale, string name, int age)
        {
            IsFemale = isFemale;
            Name = name;
            Age = age;
        }

        public bool IsFemale { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be empty");
                }

                _name = value;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Invalid Age");
                }

                _age = value;
            }
        }
        public abstract string AnimalSound { get; }

        public void ProduceSound()
        {
            Console.WriteLine(AnimalSound);
        }

        public override string ToString()
        {
            return $"Name = {Name}{Environment.NewLine}Age = {Age}{Environment.NewLine}IsFemale = {IsFemale}";
        }
    }
}
