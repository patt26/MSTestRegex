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
                            Name pattern = new Name();
                            Console.Write("Enter 1ST Name: ");
                            bool result = pattern.ValidateName(Console.ReadLine());
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
                            Name pattern0 = new Name();
                            Console.WriteLine("Enter Last Name: ");
                            bool result1 = pattern0.ValidateName1(Console.ReadLine());
                            Console.Write(result1);
                            if (result1 != true)
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
                            EmailId pattern1 = new EmailId();
                            Console.Write("Enter Email ID - ");
                            string name = Console.ReadLine();
                            bool result2 = pattern1.ValidateEmail(name);
                            Console.WriteLine(result2);

                            if (result2 != true)
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
                            PhoneNum pattern3 = new PhoneNum();
                            Console.Write("Enter Mobile Number - ");
                            string name1 = Console.ReadLine();
                            bool result3 = pattern3.PhoneValidator(name1);
                            Console.WriteLine(result3);

                            if (result3 != true)
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
                            Password pattern4 = new Password();
                            Console.Write("Enter Password - ");
                            string name2 = Console.ReadLine();
                            bool result4 = pattern4.Validate(name2);
                            Console.WriteLine(result4);

                            if (result4 != true)
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
    

