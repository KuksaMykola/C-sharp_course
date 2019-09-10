using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.MobilePhone.Test
{
    [TestClass]
    public class MessageFormaterTest
    {
        [TestMethod]
        public void NoFormat()
        {
            //Arrange
            var messageFormater = new MessageFormater();
            var message = "Test message!";

            //Act
            var resMessage = messageFormater.FormaterMethod(message);

            //Assert
            Assert.AreEqual(message+Environment.NewLine, resMessage);
        }

        [TestMethod]
        public void StartWithDateTimeFormat()
        {
            //Arrange
            var messageFormater = new MessageFormater();
            messageFormater.TimeInfo=new FakeTimeInfo("FakedTime");
            messageFormater.FormaterMethod = messageFormater.StartWithDateTimeFormat;

            //Act
            var resMessage = messageFormater.FormaterMethod(" Test message");

            //Assert
            Assert.AreEqual("FakedTime Test message" + Environment.NewLine, resMessage);
        }

        [TestMethod]
        public void EndWithDateTimeFormat()
        {
            //Arrange
            var messageFormater = new MessageFormater();
            messageFormater.TimeInfo = new FakeTimeInfo("FakedTime");
            messageFormater.FormaterMethod = messageFormater.EndWithDateTimeFormat;

            //Act
            var resMessage = messageFormater.FormaterMethod("Test message ");

            //Assert
            Assert.AreEqual("Test message FakedTime" + Environment.NewLine, resMessage);
        }

        [TestMethod]
        public void UpperCaseFormat()
        {
            //Arrange
            var messageFormater = new MessageFormater();
            messageFormater.FormaterMethod = messageFormater.UpperCaseFormat;

            //Act
            var resMessage = messageFormater.FormaterMethod("Test message");

            //Assert
            Assert.AreEqual(("TEST MESSAGE" + Environment.NewLine).ToUpper(), resMessage);
        }

        [TestMethod]
        public void LowerCaseFormat()
        {
            //Arrange
            var messageFormater = new MessageFormater();
            messageFormater.FormaterMethod = messageFormater.LowerCaseFormat;

            //Act
            var resMessage = messageFormater.FormaterMethod("Test message");

            //Assert
            Assert.AreEqual(("test message"+ Environment.NewLine).ToLower(), resMessage);
        }
    }
}
