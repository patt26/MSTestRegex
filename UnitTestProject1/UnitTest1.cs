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
            Name pattern = new Name();    //Act
            bool result = pattern.ValidateName("Pratik");  //Arrange
            Assert.IsTrue(result);  //Assert
        }
        [TestMethod]
        public void LastName()
        {
            Name pattern = new Name();
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
            EmailId pattern = new EmailId();
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
            Password pattern = new Password();
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
            PhoneNum pattern = new PhoneNum();
            bool result = pattern.PhoneValidator("91 9552689356");
            Assert.IsTrue(result);
        }
    }
}
