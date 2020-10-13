using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UnitTestProject1
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void VerifyFirstName_StartsWith_CapitalOrNot()

        {
            
                 User user = new User();
                var firstName = "Puja";
                var result = user.VerifyfirstName(firstName); ;
                Assert.IsTrue(result);

            
        }
        [TestMethod]
        public void VerifyLast_StartsWith_CapitalOrNot()

        {
            User user = new User();
            var lastname = "Yadav";
            var result = user.VerifyfirstName(lastname); ;
            Assert.IsTrue(result);
        }
    }
}
