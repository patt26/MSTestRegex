using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MSTestRegex.ReflectionPurpose;

namespace MSTestRegex
{
    class CostomException:Exception
    {
        public CostomException(string Message):base (Message)
        {

        }
        static void Main(string[] args)
        {
                Console.WriteLine("Enter Choice: \n 1: Name Validator\n 2: Email Validator\n 3: Mobile Number Validator\n 4: Password Validator\n 5:Properties");
                int choice = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (choice)
                {
                    case 1:
                        try
                        {
                            PatternRegex FirstName = new PatternRegex();
                            Console.Write("Enter 1ST Name: ");
                            bool result = FirstName.ValidateName(Console.ReadLine());
                            Console.WriteLine(result);
                            if (result != true)
                            {
                                throw new CostomException("Check Input");
                            }
                        }
                        catch (CostomException e)
                        {
                            Console.WriteLine("First Letter Should Be Capital & Minimum 3 Letters");

                        }
                        try
                        {
                            PatternRegex lastname = new PatternRegex();
                            Console.WriteLine("Enter Last Name: ");
                            bool LastName = lastname.ValidateName1(Console.ReadLine());
                            Console.Write(LastName);
                            if (LastName != true)
                            {
                                throw new CostomException("Check Input");
                            }
                        }
                        catch (CostomException e)
                        {

                            Console.WriteLine("First Letter Should Be Capital & Minimum 3 Letters");
                        }
                        break;
                    case 2:
                        try
                        {
                            PatternRegex Email = new PatternRegex();
                            Console.Write("Enter Email ID - ");
                            string EmailId = Console.ReadLine();
                            bool result = Email.ValidateEmail(EmailId);
                            Console.WriteLine(result);

                            if (result != true)
                            {
                                throw new CostomException("Check Input");
                            }
                        }
                        catch (CostomException)
                        {

                            Console.WriteLine("Email Must have in correct format");
                        }

                        break;
                    case 3:
                        try
                        {
                            PatternRegex MobNum = new PatternRegex();
                            Console.Write("Enter Mobile Number - ");
                            string PhoneNum = Console.ReadLine();
                            bool result = MobNum.PhoneValidator(PhoneNum);
                            Console.WriteLine(result);

                            if (result != true)
                            {
                                throw new CostomException("Check Input");
                            }
                        }
                        catch (CostomException e)
                        {

                            Console.WriteLine("Mobile Number Must start with 91 & Follow by space and only 10 digits");
                        }

                        break;
                    case 4:
                        try
                        {
                            PatternRegex password = new PatternRegex();
                            Console.Write("Enter Password - ");
                            string Password = Console.ReadLine();
                            bool result = password.Validate(Password);
                            Console.WriteLine(result);

                            if (result != true)
                            {
                                throw new CostomException("Check Input");
                            }
                        }
                        catch (CostomException e)
                        {

                            Console.WriteLine("Password must contain following rules\n 1)Minimum of 8 charecters.\n 2)Atleast Contain 1 Upper Case Charecter.\n 3)Atleast Contain 1 Numeric number.\n 4)Must has exactly 1 Special charecter");
                        }

                        break;
                    case 5:
                        ReflectionOnRegex.ReflectionTest();
                        break;
                   
                }

            }
            catch(CostomException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
       
    }
}
    

