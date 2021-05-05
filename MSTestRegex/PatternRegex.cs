using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSTestRegex
{
    public class ReflectionPurpose
    {

        public class PatternRegex
        {

            public const string NAME_VALIDATOR = "^[A-Z]{1}[a-z]{3,}$";
            public const string PASSWORD_VALIDATOR = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).{8,}$";
            public const string PHONE_NO_VALIDATOR = "^[91]{2}[ ]*[0-9]{10}$";
            public const string EMAIL_VALIDATOR = "^[a-zA-Z0-9]+([.]{1}[a-zA-Z0-9]+)?[@]{1}[a-zA-Z]+[.][A-Za-z]{3}$";


            public Func<string, bool> ValidateName = (FirstName) => Regex.IsMatch(FirstName, NAME_VALIDATOR);

            public Func<string, bool> ValidateName1 = (LastName) => Regex.IsMatch(LastName, NAME_VALIDATOR);

            public Func<string, bool> Validate = (Password) => Regex.IsMatch(Password, PASSWORD_VALIDATOR);

            public Func<string, bool> PhoneValidator = (PhoneNum) => Regex.IsMatch(PhoneNum, PHONE_NO_VALIDATOR);

            public Func<string, bool> ValidateEmail = (EmailId) => Regex.IsMatch(EmailId, EMAIL_VALIDATOR);

        }
    }
}
        
        
        
        
        
            

            
            
                


