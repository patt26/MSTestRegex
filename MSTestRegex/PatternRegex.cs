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


            public Func<string, string, bool> ValidateName = (FirstName, NAME_VALIDATOR) => Regex.IsMatch(FirstName, NAME_VALIDATOR);

            public Func<string, string, bool> ValidateName1 = (LastName, NAME_VALIDATOR) => Regex.IsMatch(LastName, NAME_VALIDATOR);

            public Func<string, string, bool> Validate = (Password, PASSWORD_VALIDATOR) => Regex.IsMatch(Password, PASSWORD_VALIDATOR);

            public Func<string, string, bool> PhoneValidator = (PhoneNum, PHONE_NO_VALIDATOR) => Regex.IsMatch(PhoneNum, PHONE_NO_VALIDATOR);

            public Func<string, string, bool> ValidateEmail = (EmailId, EMAIL_VALIDATOR) => Regex.IsMatch(EmailId, EMAIL_VALIDATOR);

        }
    }
}
        
        
        
        
        
            

            
            
                


