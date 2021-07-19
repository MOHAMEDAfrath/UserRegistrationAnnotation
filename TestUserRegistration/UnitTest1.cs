using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationAnnotations;

namespace TestUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        //test object creation using reflection
            [TestMethod]
            public void TestCreateObjectWithRelections()
            {
                object expected = new UserValidation();
                object actual = ReflectionFactory.CreateObjectForMoodAnalyse("UserRegistrationAnnotations.UserValidation", "UserValidation");
                expected.Equals(actual);

            }
        //test method for constructor creation
        [TestMethod]
        public void TestParameterConstructor()
        {
            object expected = new UserValidation("validation of user");
            object actual = ReflectionFactory.CreateParameterizedConstructor("UserRegistrationAnnotations.UserValidation", "UserValidation", "validation of user");
            actual.Equals(expected);
        }
      
        //set field test using reflection
        [TestMethod]
            public void TestSetFields()
            {
                string expected = "Validation of user";
                string actual = ReflectionFactory.SetMessage("message", "Validation of user");
                Assert.AreEqual(expected, actual);
            }
            
        }
}
