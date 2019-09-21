using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhone.Message;

namespace SimCorp.IMS.MobilePhone.Test.Message
{
    [TestClass]
    public class MessageFormaterTest
    {
        [TestMethod]
        public void NoFormat()
        {
            //Arrange
            var messageFormater = new MessageFormater();
            var message = new MobilePhone.Message.Message("Test message!");

            //Act
            var resMessage = messageFormater.FormaterMethod(message);

            //Assert
            Assert.AreEqual(message, resMessage);
        }

        [TestMethod]
        public void StartWithDateTimeFormat()
        {
            //Arrange
            var messageFormater = new MessageFormater();
            messageFormater.FormaterMethod = messageFormater.StartWithDateTimeFormat;

            //Act
            var message = messageFormater.FormaterMethod(new MobilePhone.Message.Message("Test message"));

            //Assert
            Assert.AreEqual(message.ReceivingTime.ToString(CultureInfo.InvariantCulture) + " Test message", message.Text);
        }

        [TestMethod]
        public void EndWithDateTimeFormat()
        {
            //Arrange
            var messageFormater = new MessageFormater();
            messageFormater.FormaterMethod = messageFormater.EndWithDateTimeFormat;

            //Act
            var message = messageFormater.FormaterMethod(new MobilePhone.Message.Message("Test message"));

            //Assert
            Assert.AreEqual("Test message "+message.ReceivingTime.ToString(CultureInfo.InvariantCulture), message.Text);
        }

        [TestMethod]
        public void UpperCaseFormat()
        {
            //Arrange
            var messageFormater = new MessageFormater();
            messageFormater.FormaterMethod = messageFormater.UpperCaseFormat;
            var message = new MobilePhone.Message.Message("TEST MESSAGE");

            //Act
            var resMessage = messageFormater.FormaterMethod(new MobilePhone.Message.Message("Test message"));

            //Assert
            Assert.AreEqual(message.ToString(), resMessage.ToString());
        }

        [TestMethod]
        public void LowerCaseFormat()
        {
            //Arrange
            var messageFormater = new MessageFormater();
            messageFormater.FormaterMethod = messageFormater.LowerCaseFormat;
            var message = new MobilePhone.Message.Message("test message");

            //Act
            var resMessage = messageFormater.FormaterMethod(new MobilePhone.Message.Message("Test message"));

            //Assert
            Assert.AreEqual(message.ToString(), resMessage.ToString());
        }
    }
}
