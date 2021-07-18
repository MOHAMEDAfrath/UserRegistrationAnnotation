using System;

namespace UserRegistrationAnnotations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UserValidation userValidation = new UserValidation();
            userValidation.GetDetails();
        }
    }
}
