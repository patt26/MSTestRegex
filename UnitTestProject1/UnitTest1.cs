using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestRegex;
using System;
using System.Text.RegularExpressions;
using static MSTestRegex.ReflectionPurpose;

namespace UnitTestProject1
{
    [TestClass]
    public class NameUnitTest1
    {
        [TestMethod]
        public void FirstName()
        {
            PatternRegex pattern = new PatternRegex();    //Act
            bool result = pattern.ValidateName("Pratik");  //Arrange
            Assert.IsTrue(result);  //Assert
        }
        [TestMethod]
        public void LastName()
        {
            PatternRegex pattern = new PatternRegex();
            bool result = pattern.ValidateName("Kharche");
            Assert.IsTrue(result);
        }
    }
    [TestClass]
    public class EmailIdUnitTest2
    {
        [TestMethod]
        public void EmailIdChecker()
        {
            PatternRegex pattern = new PatternRegex();
            bool result = pattern.ValidateEmail("kharchepratik123@gmail.com");
            Assert.IsTrue(result);
        }
    }
    [TestClass]
    public class PasswordUnitTest3
    {
        [TestMethod]
        public void PasswordChecker()
        {
            PatternRegex pattern = new PatternRegex();
            bool result = pattern.Validate("Dioluty@569");
            Assert.IsTrue(result);
        }
    }
    [TestClass]
    public class PhoneNumUnitTest4
    {
        [TestMethod]
        public void PhoneNumChecker()
        {
            PatternRegex pattern = new PatternRegex();
            bool result = pattern.PhoneValidator("91 9552689356");
            Assert.IsTrue(result);
        }
    }
}
