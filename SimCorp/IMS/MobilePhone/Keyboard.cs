namespace SimCorp.IMS.MobilePhone
{
    public class Keyboard
    {
        public Keyboard(uint numberOfKeys)
        {
            NumberOfKeys = numberOfKeys;
        }

        public Keyboard()
        {
            
        }

        public uint NumberOfKeys { get; private set; } = 10;
    }
}
