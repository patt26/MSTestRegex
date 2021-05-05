using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestRegex;
using System;
using System.Text.RegularExpressions;
using static MSTestRegex.ReflectionPurpose;

namespace UnitTestProject1
{
    public class UnitTest
    {
        public const string NAME_VALIDATOR = "^[A-Z]{1}[a-z]{3,}$";
        public const string PASSWORD_VALIDATOR = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).{8,}$";
        public const string PHONE_NO_VALIDATOR = "^[91]{2}[ ]*[0-9]{10}$";
        public const string EMAIL_VALIDATOR = "^[a-zA-Z0-9]+([.]{1}[a-zA-Z0-9]+)?[@]{1}[a-zA-Z]+[.][A-Za-z]{3}$";


        public Func<string, string, bool> ValidateName = (FirstName, NAME_VALIDATOR) => Regex.IsMatch(FirstName, NAME_VALIDATOR);

        public Func<string, string, bool> ValidateName1 = (LastName, NAME_VALIDATOR) => Regex.IsMatch(LastName, NAME_VALIDATOR);

        public Func<string, string, bool> Validate = (Password, PASSWORD_VALIDATOR) => Regex.IsMatch(Password, PASSWORD_VALIDATOR);

        public Func<string, string, bool> PhoneValidator = (PhoneNum, PHONE_NO_VALIDATOR) => Regex.IsMatch(PhoneNum, PHONE_NO_VALIDATOR);

        public Func<string, string, bool> ValidateEmail = (EmailId, EMAIL_VALIDATOR) => Regex.IsMatch(EmailId, EMAIL_VALIDATOR);
    }
     








//    [TestClass]
//    public class NameUnitTest1
//    {
//        [TestMethod]
//        public void FirstName()
//        {
//            PatternRegex pattern = new PatternRegex();    //Act
//            bool result = pattern.ValidateName("Pratik");  //Arrange
//            Assert.IsTrue(result);  //Assert
//        }
//        [TestMethod]
//        public void LastName()
//        {
//            Name pattern = new Name();
//            bool result = pattern.ValidateName("Kharche");
//            Assert.IsTrue(result);
//        }
//    }
//    [TestClass]
//    public class EmailIdUnitTest2
//    {
//        [TestMethod]
//        public void EmailIdChecker()
//        {
//            EmailId pattern = new EmailId();
//            bool result = pattern.ValidateEmail("kharchepratik123@gmail.com");
//            Assert.IsTrue(result);
//        }
//    }
//    [TestClass]
//    public class PasswordUnitTest3
//    {
//        [TestMethod]
//        public void PasswordChecker()
//        {
//            Password pattern = new Password();
//            bool result = pattern.Validate("Dioluty@569");
//            Assert.IsTrue(result);
//        }
//    }
//    [TestClass]
//    public class PhoneNumUnitTest4
//    {
//        [TestMethod]
//        public void PhoneNumChecker()
//        {
//            PhoneNum pattern = new PhoneNum();
//            bool result = pattern.PhoneValidator("91 9552689356");
//            Assert.IsTrue(result);
//        }
//    }
}
