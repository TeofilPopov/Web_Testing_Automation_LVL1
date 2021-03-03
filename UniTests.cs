using Uni;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uni.Tests
{
    [TestClass]
    public class UniTests
    {
        [TestMethod()]
        public void AddStudentTest()
        {
            Uni uni = new Uni();
            uni.AddStudent("Marcel");

            Assert.ThrowsException<ArgumentException>(() => uni.AddStudent("Marcel"));
        }
    }
}
