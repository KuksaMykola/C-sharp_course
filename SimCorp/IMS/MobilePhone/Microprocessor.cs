namespace SimCorp.IMS.MobilePhone
{
    public class Microprocessor
    {
        public Microprocessor(float frequency, uint numberOfCores)
        {
            Frequency = frequency;
            NumberOfCores = numberOfCores;
        }
        public Microprocessor()
        {

        }
        public float Frequency { get; private set; } = 1;
        public uint NumberOfCores { get; private set; } = 2;
    }
}
