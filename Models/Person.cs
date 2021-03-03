using System;

namespace CSharpLVL1.Models
{
    public class Person : IEquatable<Person>, IComparable<Person>
    {
        private int _age;
        public Person(string name1, int age)
        {
            if (Age < 0)
            {
                throw new ArgumentException("Age cannot be negative");
            }
            Age = age;
            Name1 = name1;
            Id = Guid.NewGuid().ToString();
        }
        public virtual int Age { get; set; }
        //public virtual int Age
        //{
        //    get => _age;
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new ArgumentOutOfRangeException("Age cannot be negative");
        //        }
        //    }

        //    _age = value;
        //}

        public string Name1 { get; set; }
        public string Id { get; set; }

        public int CompareTo(Person other)
        {
            return Age.CompareTo(other.Age);
        }

        public bool Equals(Person other)
        {
            return Id == other.Id;
        }

        public override string ToString()
        {
            return $"Name1 = {Name1} and Age = {Age} ID = {Id}";
        }
    }
}
