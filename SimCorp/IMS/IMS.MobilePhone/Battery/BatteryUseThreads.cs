using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Battery
{
    class BatteryUseThreads : Battery
    {
        private Thread DischargingThread;
        private Thread ChargingThread;

        public override void PlugInCharger()
        {
            SwitchChargeMode(StartCharging, true);
        }

        public override void PlugOutCharger()
        {
            SwitchChargeMode(StartDischarging, false);
        }

        private void SwitchChargeMode(PowerChangeDelegate newModeButteryFunction, bool isCharging)
        {
            ChargerPlugedIn = isCharging;
            newModeButteryFunction();
        }

        public override void StartDischarging()
        {
            if (DischargingThread == null)
            {
                DischargingThread = new Thread(new ThreadStart(Discharging));
                DischargingThread.Start();
            }
        }

        public override void StartCharging()
        {
            if (ChargingThread == null)
            {
                ChargingThread = new Thread(new ThreadStart(Charging));
                ChargingThread.Start();
            }
        }

        public override void CloseAllThreadsAndTasks()
        {
            DischargingThread?.Abort();
            ChargingThread?.Abort();
        }
    }
}
