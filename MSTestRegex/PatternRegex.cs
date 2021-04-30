using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSTestRegex
{
   public class Name
    {
        
       const string NAME_VALIDATOR = "^[A-Z]{1}[a-z]{3,}$";

        public bool ValidateName(string result)
        {
            return Regex.IsMatch(result, NAME_VALIDATOR);
        }
        public bool ValidateName1(string result1)
        {
            return Regex.IsMatch(result1, NAME_VALIDATOR);
        }
    }
    public class Password
    {
        const string PASSWORD_VALIDATOR = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).{8,}$";

        public bool Validate(string name)
        {
            return Regex.IsMatch(name, PASSWORD_VALIDATOR);
        }
    }
    public class PhoneNum
    {
       const string PHONE_NO_VALIDATOR = "^[91]{2}[ ]*[0-9]{10}$";

        public bool PhoneValidator(string name)
        {
            return Regex.IsMatch(name, PHONE_NO_VALIDATOR);
        }

       
    }
    public class EmailId
   {
        string EMAIL_VALIDATOR = "^[a-zA-Z0-9]+([.]{1}[a-zA-Z0-9]+)?[@]{1}[a-zA-Z]+[.][A-Za-z]{3}$";

        public bool ValidateEmail(string name)
        {
            return Regex.IsMatch(name, EMAIL_VALIDATOR);
        }
   }
}
