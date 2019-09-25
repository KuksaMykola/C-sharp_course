using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhone.Battery;
using SimCorp.IMS.MobilePhone;

namespace SimCorp.IMS.MobilePhone.Test.Battery
{
    [TestClass]
    public class BatteryTest
    {
        private List<ParallelExectuionType> exectuionTypes = new List<ParallelExectuionType>() { ParallelExectuionType.Thread, ParallelExectuionType.Task };

        [TestMethod]
        public void DecreaseAndNotLessZeroPercent()
        {
            foreach (var executionType in exectuionTypes)
            {
                //Arange
                var battery = BatteryFactory.Create(executionType);
                battery.TimeToChargeOnePercent = 1;
                Assert.IsTrue(battery.Charge > 0);

                //Act
                battery.StartDischarging();
                Thread.Sleep(300);

                //Assert
                Assert.AreEqual(0, battery.Charge);

                battery.CloseAllThreadsAndTasks();
            }
        }

        [TestMethod]
        public void IncreaseChargeAndNotMore100Percent()
        {
            foreach (var executionType in exectuionTypes)
            {
                //Arange
                var battery = BatteryFactory.Create(executionType);
                battery.TimeToChargeOnePercent = 1;
                battery.StartDischarging();
                Thread.Sleep(300);
                Assert.IsTrue(battery.Charge == 0);

                //Act
                battery.PlugInCharger();
                Thread.Sleep(300);

                //Assert
                Assert.AreEqual(100, battery.Charge);

                battery.CloseAllThreadsAndTasks();
            }
        }
    }
}
