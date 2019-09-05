namespace SimCorp.IMS.MobilePhone.Audio
{
    public class Speaker : IPlayback
    {
        private IOutput Output;

        public Speaker(IOutput output)
        {
            Output = output;
        }
        public Speaker(float frequency, float power)
        {
            Frequency = frequency;
            Power = power;
        }

        public Speaker()
        {
            
        }

        public float Frequency { get; private set; } = 20;
        public float Power { get; private set; } = 50;

        public void Play(object data)
        {
            System.Console.WriteLine($"{nameof(Speaker)} sound");
        }
    }

  }
