namespace SimCorp.IMS.Audio
{
    internal class Speaker
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
    }

  }
