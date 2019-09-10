using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.MobilePhone.Test
{
    [TestClass]
    public class SMSProviderTest
    {
        private List<string> ReceivedSMS;
        [TestMethod]
        public void SimulateSMS()
        {
            //Arrange
            var smsProvider = new SMSProvider(3);
            ReceivedSMS =new List<string>();

            //Act            
            smsProvider.SMSReceived+=new SMSReceivedDelegate(OnSMSReceivedHandler);
            smsProvider.SimulateSMS();
            
            //Assert
            var masterReceivedSMS=new List<string>() {"Message #1 received", "Message #2 received", "Message #3 received"};
            for (var i = 0; i < masterReceivedSMS.Count; i++)
            {
                Assert.AreEqual(ReceivedSMS[i],masterReceivedSMS[i]);
            }     
        }

        [TestMethod]
        public void SimulateSMSNoHandlers()
        {
            //Arrange
            var smsProvider = new SMSProvider(3);
            ReceivedSMS = new List<string>();

            //Act            
            smsProvider.SimulateSMS();

            //Assert
            Assert.AreEqual(ReceivedSMS.Count,0);
        }

        private void OnSMSReceivedHandler(string message)
        {   
            ReceivedSMS.Add(message);
        }
    }
}
