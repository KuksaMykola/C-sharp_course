using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Battery
{
    class BatteryUseTasks:Battery
    {
        public override void PlugInCharger()
        {
            ChargerPlugedIn = true;
            StartCharging();
        }

        public override void PlugOutCharger()
        {
            ChargerPlugedIn = false;
            StartDischarging();
        }

        public override void StartDischarging()
        {
            DischargingTask();
        }

        private async Task DischargingTask()
        {
            await Task.Run(() => Discharging());
        }

        public override void StartCharging()
        {
            ChargingTask();
        }

        public override void CloseAllThreadsAndTasks()
        {
        }

        private async Task ChargingTask()
        {
            await Task.Run(() =>Charging());
        }

    }
}
