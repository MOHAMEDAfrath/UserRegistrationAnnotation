using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationAnnotations
{
    public class ReflectionFactory
    {
        //creates object for a class using assembly
        public static object CreateObjectForMoodAnalyse(string classname, string constructorname)
        {
            string pattern = @"." + constructorname + "$";
            Match result = Regex.Match(classname, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type type = assembly.GetType(classname);
                    return Activator.CreateInstance(type);
                }
                catch (ArgumentNullException ex)
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "No class Found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_CONSTRUCTOR_FOUND, "No constructor found");
            }
        }
        //using relection to create parameterized constructor
        public static object CreateParameterizedConstructor(string classname, string constructorname, string message)
        {
            Type type = typeof(UserValidation);
            if (type.Name.Equals(classname) || type.FullName.Equals(classname))
            {
                if (type.Name.Equals(constructorname))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                    object objectConstructor = constructorInfo.Invoke(new object[] { message });
                    return objectConstructor;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.NO_CONSTRUCTOR_FOUND, "No constructor found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "No class found");
            }

        }
        //using reflection to access the method 
        public static string InvokeMethod(string methodname)
        {
            try
            {
                Type type = Type.GetType("UserRegistrationAnnotations.UserValidation");
                object methodObject = ReflectionFactory.CreateParameterizedConstructor("UserRegistrationAnnotations.UserValidation", "UserValidation","Done");
                MethodInfo methodInfo = type.GetMethod(methodname);
                object method = methodInfo.Invoke(methodObject, null);
                return method.ToString();


            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NO_METHOD_FOUND, "No method found");
            }
        }
        //using reflection to add data to fields
        public static string SetMessage(string variable, string message)
        {
            try
            {
                UserValidation moodAnalyzer = new UserValidation();
                Type type = typeof(UserValidation);
                FieldInfo fieldInfo = type.GetField(variable, BindingFlags.Public | BindingFlags.Instance);
                if (message == null)
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Message is empty");
                }
                else
                {
                    fieldInfo.SetValue(moodAnalyzer, message);
                    return moodAnalyzer.message;
                }

            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NO_FIELD_FOUND, "No field found");
            }
        }
    }
}
