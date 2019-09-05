namespace SimCorp.IMS.MobilePhone.Audio
{
    internal class Speaker : IPlayback
    {
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
