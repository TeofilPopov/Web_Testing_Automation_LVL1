using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uni
{
    public class Course
    {
        public List<Student> _students = new List<Student>();

        public void JoinCourse(Student student)
        {

            if (_students.Count>=30)
            {
                throw new ArgumentException("No more sudents are allowed");
            }
            _students.Add((student));
        }

        public void LeaveCourse(string name)
        {
            if (!_students.Any(x=>x.Name.Equals(name)))
            {
                throw new ArgumentException($"Student {name} is not in this Course");
            }

            _students.Remove((_students.First(x => x.Name.Equals((name)))));
        }

    }
}
