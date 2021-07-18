using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationAnnotations
{
    public class UserValidation
    {
        public string message;
        public UserValidation()
        {

        }
        /// <summary>
        /// Annoations
        /// </summary>
        UserProperties userProperties = new UserProperties();
        public string GetDetails()
        {
            Console.WriteLine("Enter first name");
            userProperties.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            userProperties.LastName = Console.ReadLine();
            Console.WriteLine("Enter Email");
            userProperties.Email = Console.ReadLine();
            Console.WriteLine("Enter mobile number:");
            userProperties.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Password");
            userProperties.Password = Console.ReadLine();
            return "Successfully got the detail";
            ValidatorDemo();

        }
        public void ValidatorDemo()
        {
            ValidationContext validationContext = new ValidationContext(userProperties,null,null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(userProperties,validationContext,validationResults,true);
            if (!valid)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Invalid Properties");
                foreach(ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine("{0}",validationResult.ErrorMessage);
                }
            }

        }

    }
}
