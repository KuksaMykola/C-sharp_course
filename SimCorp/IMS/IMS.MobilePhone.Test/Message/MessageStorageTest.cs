using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhone.Message;

namespace SimCorp.IMS.MobilePhone.Test.Message
{
    [TestClass]
    public class MessageStorageTest
    {
        private MessageStorage Storage;
        private Mobile MobilePhone;

        public MessageStorageTest()
        {
            Storage = new MessageStorage();
            
            Storage.AddMessage(new MobilePhone.Message.Message("user1","num1","text1",new DateTime(2001,01,01)));
            Storage.AddMessage(new MobilePhone.Message.Message("user1", "num1", "text2", new DateTime(2001, 02, 02)));
            Storage.AddMessage(new MobilePhone.Message.Message("user2", "num2", "text3", new DateTime(2002, 01, 01)));
            Storage.AddMessage(new MobilePhone.Message.Message("user3", "num3", "text4", new DateTime(2002, 03, 01)));
            Storage.AddMessage(new MobilePhone.Message.Message("user3", "num3", "text14", new DateTime(2003, 03, 01)));
            Storage.AddMessage(new MobilePhone.Message.Message("user4", "num4", "text 4", new DateTime(2003, 03, 01)));
        }

        [TestMethod]
        public void SearchByUser()
        {
            //Arange
            var expectedMessages = new List<MobilePhone.Message.Message>();
            expectedMessages.Add(new MobilePhone.Message.Message("user1", "num1", "text1", new DateTime(2001, 01, 01)));
            expectedMessages.Add(new MobilePhone.Message.Message("user1", "num1", "text2", new DateTime(2001, 02, 02)));

            //Act
            Storage.SetFilterParams("user1","any text",new DateTime(),new DateTime(),(a,b)=>a||b);
            var actualMesseges = Storage.SearchByUser();

            //Assert
            Assert.AreEqual(expectedMessages.Count, actualMesseges.Count);
            var actual = actualMesseges.GetEnumerator();
            var expected = expectedMessages.GetEnumerator();
            while (actual.MoveNext() && expected.MoveNext())
            {
                Assert.AreEqual(actual.Current, expected.Current);
            }
        }

        [TestMethod]
        public void SearchByText()
        {
            //Arange
            var expectedMessages = new List<MobilePhone.Message.Message>();
            expectedMessages.Add(new MobilePhone.Message.Message("user1", "num1", "text1", new DateTime(2001, 01, 01)));
            expectedMessages.Add(new MobilePhone.Message.Message("user3", "num3", "text14", new DateTime(2003, 03, 01)));

            //Act
            Storage.SetFilterParams("user1", "1", new DateTime(), new DateTime(), (a, b) => a || b);
            var actualMesseges = Storage.SearchByText();

            //Assert
            Assert.AreEqual(expectedMessages.Count, actualMesseges.Count);
            var actual = actualMesseges.GetEnumerator();
            var expected = expectedMessages.GetEnumerator();
            while (actual.MoveNext() && expected.MoveNext())
            {
                Assert.AreEqual(actual.Current, expected.Current);
            }
        }

        [TestMethod]
        public void SearchByTextEmpty()
        {
            //Arange

            //Act
            Storage.SetFilterParams("user1", "", new DateTime(), new DateTime(), (a, b) => a || b);
            var actualMesseges = Storage.SearchByText();

            //Assert
            Assert.AreEqual(Storage.Count(), actualMesseges.Count);
            var actual = actualMesseges.GetEnumerator();
            var expected = Storage.GetEnumerator();
            while (actual.MoveNext() && expected.MoveNext())
            {
                Assert.AreEqual(actual.Current, expected.Current);
            }
        }

        [TestMethod]
        public void SearchByTextWhiteSpace()
        {
            //Arange
            var expectedMessages = new List<MobilePhone.Message.Message>();
            expectedMessages.Add(new MobilePhone.Message.Message("user4", "num4", "text 4", new DateTime(2003, 03, 01)));


            //Act
            Storage.SetFilterParams("user1", " ", new DateTime(), new DateTime(), (a, b) => a || b);
            var actualMesseges = Storage.SearchByText();

            //Assert
            Assert.AreEqual(expectedMessages.Count, actualMesseges.Count);
            var actual = actualMesseges.GetEnumerator();
            var expected = expectedMessages.GetEnumerator();
            while (actual.MoveNext() && expected.MoveNext())
            {
                Assert.AreEqual(actual.Current, expected.Current);
            }
        }

        [TestMethod]
        public void SearchByDate()
        {
            //Arange
            var expectedMessages = new List<MobilePhone.Message.Message>();
            expectedMessages.Add(new MobilePhone.Message.Message("user1", "num1", "text2", new DateTime(2001, 02, 02)));
            expectedMessages.Add(new MobilePhone.Message.Message("user2", "num2", "text3", new DateTime(2002, 01, 01)));
            expectedMessages.Add(new MobilePhone.Message.Message("user3", "num3", "text4", new DateTime(2002, 03, 01)));

            //Act
            Storage.SetFilterParams("user1", "any text", new DateTime(2001, 02, 02), new DateTime(2002, 03, 01), (a, b) => a || b);
            var actualMesseges = Storage.SearchByDate();

            //Assert
            Assert.AreEqual(expectedMessages.Count, actualMesseges.Count);
            var actual = actualMesseges.GetEnumerator();
            var expected = expectedMessages.GetEnumerator();
            while (actual.MoveNext() && expected.MoveNext())
            {
                Assert.AreEqual(actual.Current, expected.Current);
            }
        }

        [TestMethod]
        public void FilterAnd()
        {
            //Arange
            var expectedMessages = new List<MobilePhone.Message.Message>();
            expectedMessages.Add(new MobilePhone.Message.Message("user1", "num1", "text1", new DateTime(2001, 01, 01)));

            //Act
            Storage.SetFilterParams("user1", "text1", new DateTime(2001, 01, 01), new DateTime(2002, 03, 01), (a, b) => a && b);
            var actualMesseges = Storage.GetFilteredMessages().ToList();

            //Assert
            Assert.AreEqual(expectedMessages.Count, actualMesseges.Count);
            var actual = actualMesseges.GetEnumerator();
            var expected = expectedMessages.GetEnumerator();
            while (actual.MoveNext() && expected.MoveNext())
            {
                Assert.AreEqual(actual.Current, expected.Current);
            }
        }

        [TestMethod]
        public void AddMessage()
        {
            //Arrange
            MobilePhone= new SimcorpMobile("test phone");
            var expectedMessages = new List<MobilePhone.Message.Message>()
                {
                    new MobilePhone.Message.Message("user1","num1","Message #1 received",new DateTime()),
                    new MobilePhone.Message.Message("user1","num1","Message #2 received",new DateTime()),
                    new MobilePhone.Message.Message("user1","num1","Message #3 received",new DateTime())
                };
            MobilePhone.MessageStorage.SetFilterParams("All","",DateTime.MinValue, DateTime.MaxValue, (a,b)=>a||b);

            //Act 
            MobilePhone.MessageStorage.Capacity = expectedMessages.Count;
            MobilePhone.StartMessaging();
            System.Threading.Thread.Sleep(4000);

            //Assert
            Assert.AreEqual(expectedMessages.Count, MobilePhone.MessageStorage.Count());
            var actual = MobilePhone.MessageStorage.GetEnumerator();
            var expected = expectedMessages.GetEnumerator();
            while (actual.MoveNext() && expected.MoveNext())
            {
                Assert.AreEqual(actual.Current.ToString(), expected.Current.ToString());
            }
        }
    }
}
