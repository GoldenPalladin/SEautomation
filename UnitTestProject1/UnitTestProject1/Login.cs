using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Initialisation;
using UnitTestProject1.Login;

namespace InitialTests
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void checkLogin(User user)
        {
            SEloginPage login = new SEloginPage();
            SELoginResult result = login.doLogin(user);
            Assert.IsTrue(result.getMenuLink().Contains("My Scopes"));
        }
    }
}
