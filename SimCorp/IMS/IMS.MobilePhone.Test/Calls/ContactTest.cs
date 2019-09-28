using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhone.Calls;

namespace SimCorp.IMS.MobilePhone.Test.Calls
{
    [TestClass]
    public class ContactTest
    {
        [TestMethod]
        public void EqualsTest()
        {
            //Arrange
            var contact1=new Contact("contact_1","+380971234569");
            var contact2=new Contact("contact_1","+380974561239");

            //Act
            var res = contact1.Equals(contact2);

            //Assert
            Assert.IsTrue(contact1.Equals(contact2));
        }
    }
}
