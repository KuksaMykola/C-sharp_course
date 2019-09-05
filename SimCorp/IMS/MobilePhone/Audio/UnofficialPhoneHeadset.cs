namespace SimCorp.IMS.MobilePhone.Audio
{
    public class UnofficialPhoneHeadset:IPlayback
    {
        public void Play(object data)
        {
            System.Console.WriteLine($"{nameof(UnofficialPhoneHeadset)} sound");
        }

        public override string ToString()
        {
            return nameof(UnofficialPhoneHeadset);
        }
    }
}
