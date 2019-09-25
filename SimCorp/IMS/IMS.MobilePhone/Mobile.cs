using System.Text;
using SimCorp.IMS.MobilePhone.Audio;
using SimCorp.IMS.MobilePhone.Battery;
using SimCorp.IMS.MobilePhone.Charg;
using SimCorp.IMS.MobilePhone.Display;
using SimCorp.IMS.MobilePhone.Message;

namespace SimCorp.IMS.MobilePhone
{
    public enum ParallelExectuionType { Thread,Task}
    public abstract class Mobile
    {
        protected Mobile(string name, CircuitBoard circuitBoard, Battery.Battery battery, Antenna antenna, Keyboard keyboard,
            Microphone microphone, Speaker speaker)
        {
            Name = name;
            CircuitBoard = circuitBoard;
            Battery = battery;
            Antenna = antenna;
            Keyboard = keyboard;
            Microphone = microphone;
            Speaker = speaker;
        }

        protected Mobile(string name)
        {
            Name = name;
        }

        protected Mobile()
        {
        }


        public void Show(IScreenImage screenImage)
        {

            Screen.Show(screenImage);
        }

        public override string ToString()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Phone Name: {Name}");
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            descriptionBuilder.AppendLine(CircuitBoard.Ram.ToString());
            descriptionBuilder.AppendLine(CircuitBoard.Rom.ToString());
            descriptionBuilder.AppendLine(CircuitBoard.Storage.ToString());
            descriptionBuilder.AppendLine(Battery.ToString());
            return descriptionBuilder.ToString();
        }

        public void Play(object data)
        {
            PlayBackComponent.Play(data);
        }

        public void Charge()
        {
            ChargerDevice.Charge();
        }

        public void StartMessaging()
        {
            if (SMSProvider == null)
            {
                SMSProvider = new SMSProviderUseTasks(MessageStorage.Capacity);
                SMSProvider.SMSReceived += new SMSReceivedDelegate(MessageStorage.AddMessage);
            }
            SMSProvider.StartMessaging();
        }

        public void CloseThreads()
        {
            SMSProvider.CloseAllThreadsAndTasks();
        }
        public void StopMessaging()
        {
            SMSProvider.StopMessaging();
        }
        public string Name { get; set; } = "NewPhone";
        public CircuitBoard CircuitBoard { get; private set; } = new CircuitBoard();
        public Battery.Battery Battery { get; private set; } = BatteryFactory.Create(ParallelExectuionType.Thread);
        public Antenna Antenna { get; private set; } = new Antenna();
        public abstract Screen Screen { get; }
        public Keyboard Keyboard { get; private set; } = new Keyboard();
        public Microphone Microphone { get; private set; } = new Microphone();
        public Speaker Speaker { get; private set; } = new Speaker();
        public IPlayback PlayBackComponent { get; set; }
        public ICharger ChargerDevice { get; set; }
        public MessageStorage MessageStorage { get; set; } =  new MessageStorage();
        private SMSProvider SMSProvider { get; set; }
    }

}
