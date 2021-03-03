using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uni
{
    public class Uni
    {
        private List<Student> _students;
        private int _currentId;

        public Uni()
        {
            _students = new List<Student>();
            _currentId = 10000;
        }

        public void AddStudent(string name)
        {
            if (_students.Any(x=>x.Name.Equals(name)))
            {
                throw new ArgumentException($"Student with name {name} alreade exists.");
            }

            Student student = new Student(name, _currentId++);
            _students.Add(student);
        }
    }
}
