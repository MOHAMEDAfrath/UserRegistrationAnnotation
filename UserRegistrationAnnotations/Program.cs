using System;

namespace UserRegistrationAnnotations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using reflection accessing the method from other class
            ReflectionFactory.InvokeMethod("GetDetails");
        }
    }
}
