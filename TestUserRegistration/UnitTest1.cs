using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationAnnotations;

namespace TestUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            public void TestCreateObjectWithRelections()
            {
                object expected = new UserValidation();
                object actual = ReflectionFactory.CreateObjectForMoodAnalyse("UserRegistrationAnnotations.UserValidation", "UserValidation");
                expected.Equals(actual);

            }
        [TestMethod]
        public void TestParameterConstructor()
        {
            object expected = new UserValidation(null);
            object actual = ReflectionFactory.CreateParameterizedConstructor("UserRegistrationAnnotations.UserValidation", "UserValidation", "Happy");
            actual.Equals(expected);
        }
      
        
        [TestMethod]
            public void TestSetFields()
            {
                string expected = "Happy";
                string actual = ReflectionFactory.SetMessage("message", "Happy");
                Assert.AreEqual(expected, actual);
            }
            
        }
}
