using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Uni.Tests
{
    [TestClass()]
    public class StudentTests
    {

        private static Student _student;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _student = new Student("Ivan Petrov", 10000);
        }

        [TestMethod()]
        public void Throw_Exception_When_Id_Is_Bigger_Than_99999()
        {
            Assert.ThrowsException<ArgumentException>(() => new Student("Anton", 100000));
            //Assert.ThrowsException<ArgumentException>(() => _student.Id == 10000000);
        }

        [TestMethod()]
        public void Throw_Exception_When_Id_Is_Smaller_Than_10000()
        {
            Assert.ThrowsException<ArgumentException>(() => new Student("Anton", 10));
        }

        [TestMethod()]
        public void Get_Id_and_Name_Should_Succeed()
        {
            var newStudent =  new Student("Anton", 10009);

            Assert.IsNotNull(newStudent);
            Assert.AreEqual(10009, newStudent.Id );
        }
    }
}