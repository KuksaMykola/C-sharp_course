namespace SimCorp.IMS.MobilePhone.Audio
{
    public class UnofficialPhoneHeadset:IPlayback
    {
        private IOutput Output;

        public UnofficialPhoneHeadset(IOutput output)
        {
            Output = output;
        }

        public void Play(object data)
        {
            Output.WriteLine($"{nameof(UnofficialPhoneHeadset)} sound");
        }

        public override string ToString()
        {
            return nameof(UnofficialPhoneHeadset);
        }
    }
}
