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
        [DataRow("12345", true)]
        [DataRow("123", false)]
        public void CheckPin_SHouldReturn_True_IfValid(string pin, bool expected)
        {
            bool result = methood.Pin(pin);
            Assert.AreEqual(expected, result);
        }
    }
}