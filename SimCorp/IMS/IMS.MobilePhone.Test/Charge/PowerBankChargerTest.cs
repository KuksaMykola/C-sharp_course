using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhone.Charg;

namespace SimCorp.IMS.MobilePhone.Test.Charge
{
    [TestClass]
    public class PowerBankChargerTest
    {
        [TestMethod]
        public void Charge()
        {
            //Arrange
            var mb = new SimcorpMobile("test_mobile");
            var output = new FakeOutput();
            var charger = new PowerBankCharger(output);
            mb.ChargerDevice = charger;

            //Act
            mb.Charge();

            //Assert
            Assert.AreEqual(output.WrittenText, "PowerBankCharger charg");
        }
    }
}
