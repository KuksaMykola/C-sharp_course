using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhone.Audio;

namespace SimCorp.IMS.MobilePhone.Test
{
    [TestClass]
    public class iPhoneHeadsetTest
    {
        [TestMethod]
        public void Play()
        {
            //Arrange
            var mb = new SimcorpMobile("test_mobile");
            var output = new FakeOutput();
            var playback = new iPhoneHeadset(output);
            mb.PlayBackComponent = playback;

            //Act
            mb.Play("data");

            //Assert
            Assert.AreEqual(output.WrittenText, "iPhoneHeadset sound");
        }
    }
}
