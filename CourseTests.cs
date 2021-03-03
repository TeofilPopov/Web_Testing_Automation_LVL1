using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uni;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Uni.Tests
{
    [TestClass()]
    public class CourseTests
    {
        [TestMethod]
        public void Check_That_No_More_Than_30_Students_Can_Join_One_Course()
        {
            Course course = new Course();
            for (int i = 0; i < 30; i++)
            {
                course.JoinCourse(new Student($"Ivan Jr.{i}", 10000 + i));
            }

            //Assert.ThrowsException<ArgumentException>(Action course.JoinCourse(new Student("Dora", 12345)));
            Assert.ThrowsException<ArgumentException>(() => course.JoinCourse(new Student("Dora", 12345)));
        }

        [TestMethod()]
        public void Throw_Exception_When_Student_Who_Doe_Not_Joined_But_Leave_A_Course()
        {
            Course course = new Course();
            Assert.ThrowsException<ArgumentException>(() => course.LeaveCourse("Ivon"));
        }

        [TestMethod()]
        public void Student_That_Join_A_Course_Can_Leave_It()
        {
            Course course = new Course();
            course.JoinCourse(new Student("John", 20000));
            course.LeaveCourse("John");

            Assert.IsTrue(course._students.Count == 0);
        }

    }
}