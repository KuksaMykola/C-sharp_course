using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhone.Calls;

namespace SimCorp.IMS.MobilePhone.Test.Calls
{
    [TestClass]
    public class CallListTest
    {
        [TestMethod]
        public void AddCallTest()
        {
            //Arrange
            var expected = new List<Call>();
            expected.Add(new Call(new Contact("cont1", "num1"), new DateTime(2019, 09, 27), CallDirection.Outgoing, "num11", 1));
            expected.Add(new Call(new Contact("cont2", "num2"), new DateTime(2019, 09, 28), CallDirection.Incoming, "num11", 1));
            expected.Add(new Call(new Contact("cont1", "num1"), new DateTime(2019, 09, 29), CallDirection.Incoming, "num11", 3));


            //Act
            var callList=new CallList();
            callList.AddCall(expected[0]);
            callList.AddCall(new Call(new Contact("cont1", "num1"), new DateTime(2019, 09, 29), CallDirection.Incoming, "num11", 1));
            callList.AddCall(new Call(new Contact("cont1", "num1"), new DateTime(2019, 09, 29), CallDirection.Incoming, "num11", 1));
            callList.AddCall(new Call(new Contact("cont1", "num1"), new DateTime(2019, 09, 30), CallDirection.Incoming, "num11", 1));
            callList.AddCall(expected[1]);

            //Assert
            Assert.AreEqual(expected.Count,callList.Calls.Count);
            var exp = expected.GetEnumerator();
            var res = callList.Calls.GetEnumerator();
            while (exp.MoveNext()&&res.MoveNext())
            {
                Assert.AreEqual(exp.Current,res.Current);
                Assert.IsTrue(exp.Current.CountCallsInRow==res.Current.CountCallsInRow);
            }
        }
    }
}
