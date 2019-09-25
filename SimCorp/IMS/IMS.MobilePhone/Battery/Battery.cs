using System;
using System.Threading;

namespace SimCorp.IMS.MobilePhone.Battery
{
    public delegate void PowerChangeDelegate();
    public abstract class Battery
    {
        public event PowerChangeDelegate PowerIncreased;
        public event PowerChangeDelegate PowerDecreased;
        public abstract void PlugInCharger();
        public abstract void PlugOutCharger();

        public abstract void StartDischarging();
        public abstract void StartCharging();
        public abstract void CloseAllThreadsAndTasks();

        public Battery(float length, float width, float thickness, float capacity, float voltage, BatteryType type)
        {
            Capacity = capacity;
            Voltage = voltage;
            Type = type;
        }
        public Battery()
        {
        }

        public Battery(int initialCharge)
        {
            Charge = initialCharge;
        }

        protected void RaisePowerDecreased()
        {
            Charge--;
            PowerDecreased?.Invoke();
        }

        protected void RaisePowerIncreased()
        {
            Charge++;
            PowerIncreased?.Invoke();
        }

        protected void Discharging()
        {
            while (true)
            {
                if (Charge > 0 && !ChargerPlugedIn)
                {
                    lock (Locker)
                    {
                        RaisePowerDecreased();
                    }
                }
                Thread.Sleep(TimeToChargeOnePercent);
            }
        }

        protected void Charging()
        {
            while (true)
            {
                if (Charge < 100 && ChargerPlugedIn)
                {
                    lock (Locker)
                    {
                        RaisePowerIncreased();
                    }
                }
                Thread.Sleep(TimeToChargeOnePercent);
            }
        }
        
        public override string ToString()
        {
            return $"Battery volume is {Capacity}";
        }

        public float Capacity { get; private set; } = 3000;
        public float Voltage { get; private set; } = 2.5f;
        public BatteryType Type { get; private set; } = BatteryType.LithiumIon;
        public int Charge { get; protected set; }= 100;
        protected bool ChargerPlugedIn = false;
        public int TimeToChargeOnePercent { get; set; } = 100;
        protected Object Locker = new Object();
    }
}
