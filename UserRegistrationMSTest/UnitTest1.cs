using RegexUserRegistration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly UserRegistration userRegistration;
        public UnitTest1()
        {
            userRegistration = new UserRegistration();
        }

        #region UC-1
        [TestMethod]
        public void UserFirstName()
        {
            var result = userRegistration.ValidateFirstName("Shashank");
            Assert.AreEqual(true, result);
        }
        #endregion UC-1

        #region UC-2
        [TestMethod]
        public void UserLastName()
        {
            var result = userRegistration.ValidateLastName("Pateriya");
            Assert.AreEqual(true, result);
        }
        #endregion UC-2

        #region UC-3
        [TestMethod]
        public void UserEmail()
        {
            var result = userRegistration.validateEmail("shashankpateriya4@gmail.com");
            Assert.AreEqual(true, result);
        }
        #endregion UC-3

        #region UC-4
        [TestMethod]
        public void UserPhoneNumber()
        {
            var result = userRegistration.validatenumber("91 7974146706");
            Assert.AreEqual(true, result);
        }
        #endregion UC-4

        #region UC-5
        [TestMethod]
        public void UserPassword()
        {
            var result = userRegistration.validatePassword("Shashank@123");
            Assert.AreEqual(true, result);
        }
        #endregion UC-5
    }
}