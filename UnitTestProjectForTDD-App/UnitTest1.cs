using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_App;

namespace UnitTestProjectForTDD_App
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testThatWeCanGetTheFirstName()
        {
            // Arrange
            var user = new User();

            // Act
            user.FirstName = "Bill";

            // Assert
            Assert.AreEqual(user.FirstName, "Bill");


        }
    }
}
