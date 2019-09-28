using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhone.Calls;

namespace SimCorp.IMS.MobilePhone.Test.Calls
{
    [TestClass]
    public class CallTest
    {
        [TestMethod]
        public void EqualsTrueTest()
        {
            //Arrange
            var contact1=new Contact("contact1","num11");
            contact1.AddNumber("num12");
            var call1=new Call(contact1,new DateTime(2019,09,27),CallDirection.Incoming,"num11",1);

            var call2=new Call(contact1,new DateTime(2019,09,27),CallDirection.Incoming,"num11",2);

            //Act
            var res = call1.Equals(call2);
            var res2 =call1.Equals(new Call(contact1, new DateTime(2019, 09, 29), CallDirection.Incoming, "num11", 1));

            //Assert
            Assert.IsTrue(res);
            Assert.IsTrue(res2);
        }

        [TestMethod]
        public void EqualsFalse()
        {
            //Arrange
            var contact1 = new Contact("contact1", "num11");
            contact1.AddNumber("num12");
            var call1 = new Call(contact1, new DateTime(2019, 09, 27), CallDirection.Incoming, "num11", 1);

            var contact2 = new Contact("contact2", "num21");

            //Act
            var resList = new List<bool>();
            var userFail = call1.Equals(new Call(contact2, new DateTime(2019, 09, 27), CallDirection.Incoming, "num11", 2));
            resList.Add(userFail);
            var dateFail = call1.Equals(new Call(contact1, new DateTime(2019, 09, 26), CallDirection.Incoming, "num11", 1));
            resList.Add(dateFail);
            var directionFail = call1.Equals(new Call(contact1, new DateTime(2019, 09, 27), CallDirection.Outgoing, "num11", 1));
            resList.Add(directionFail);
            var numberFail = call1.Equals(new Call(contact1, new DateTime(2019, 09, 27), CallDirection.Incoming, "num", 1));
            resList.Add(numberFail);

            //Assert
            foreach (var res in resList)
            {
                Assert.IsFalse(res);
            }
        }

        [TestMethod]
        public void CompareToTest()
        {
            //Arrange
            var contact1 = new Contact("contact1", "num11");
            var call1 = new Call(contact1, new DateTime(2019, 09, 27), CallDirection.Incoming, "num11", 1);
            var call2 = new Call(contact1, new DateTime(2019, 09, 28), CallDirection.Incoming, "num11", 2);

            //Act
            var preced = call1.CompareTo(call2);
            var follow = call1.CompareTo(new Call(contact1, new DateTime(2019, 09, 26), CallDirection.Incoming, "num11", 1));
            var same = call1.CompareTo(call1);

            //Assert
            Assert.IsTrue(preced==-1);
            Assert.IsTrue(follow==1);
            Assert.IsTrue(same==0);
        }

    }
}
