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
        //Invoke method for happy message
            [TestMethod]
            public void TestInvokeMethod()
            {
                string expected = "Successfully got the details";
               string actual = ReflectionFactory.InvokeMethod("GetDetails");
                Assert.AreEqual(expected, actual);
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
