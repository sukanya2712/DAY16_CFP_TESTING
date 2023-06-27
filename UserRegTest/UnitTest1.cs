using Userregnormal;

namespace UserRegTest
{
    [TestClass]
    public class UnitTest1
    {
        private UserReg methood;

        [TestInitialize]

        public void Setup()
        {
            methood = new UserReg();
        }

        [TestMethod]
        [DataRow("Sukanya", true)]
        [DataRow("sukanya", false)]
        public void CheckFirstName_SHouldReturn_True_IfValid(string name, bool expected)
        {
            bool result = methood.FirstName(name);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("sukanya@gmail.con", true)]
        [DataRow("sukanya@com", false)]
        public void CheckEmail_SHouldReturn_True_IfValid(string email, bool expected)
        {
            bool result = methood.Email(email);
            Assert.AreEqual(expected, result);
        }
    }
}