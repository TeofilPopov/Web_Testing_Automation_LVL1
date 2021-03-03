using System;
using System.Collections.Generic;
using System.Text;

namespace Uni
{
    public class Student
    {
        //public Student(string name, int id)
        //{
        //    if (string.IsNullOrEmpty(name) || id < 10000 || id > 99999)
        //    {
        //        throw new ArgumentException("Invalid input");
        //    }

        //    Name = name;
        //    Id = id;
        //}

        //public string Name { get; set; }
        //public int Id { get; set; }

        private int _id;
        private string _name;
        //private string _fullName;

        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Name");
                }

                _name = value;
            }
        }

        public int Id
        {
            get => _id;
            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentException("Invalid number");
                }

                _id = value;
            }
        }

        //public string FullName
        //{
        //    get => _fullName;
        //    set
        //    {
        //        if (value=="TeofilPopov")
        //        {
        //            throw new ArgumentException("Invalid");
        //        }

        //        _fullName = value;
        //    }
        //}
    }
}
