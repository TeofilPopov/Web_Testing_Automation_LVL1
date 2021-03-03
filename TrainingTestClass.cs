using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpLVL1.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class TrainingTestClass
    {
        private static GoldenEditionBook _goldEditionBook;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _goldEditionBook = new GoldenEditionBook("Inferno", "Dan Brown", 10);
        }
        
        [TestMethod]
        public void Check30PercentageRequirement()
        {

            Assert.AreEqual(13, _goldEditionBook.Price);
        }

        [TestMethod]
        public void CheckAuthorPropertySetSuccessfully()
        {
            Assert.AreEqual("Dan Brown", _goldEditionBook.Author);
        }
    }
}
