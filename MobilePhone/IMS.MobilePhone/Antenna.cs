namespace SimCorp.IMS.MobilePhone
{
    internal class Antenna
    {
        public Antenna(uint length,uint frequency)
        {
            Length = length;
            Frequency = frequency;
        }
        public Antenna()
        {
        }
        public uint Length { get; private set; } = 3;
        public uint Frequency { get; private set; } = 2000000;
    }
}
