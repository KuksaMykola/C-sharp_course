namespace SimCorp.IMS.MobilePhone.Audio
{
    class UnofficialPhoneHeadset:IPlayback
    {
        public void Play(object data)
        {
            System.Console.WriteLine($"{nameof(UnofficialPhoneHeadset)} sound");
        }
    }
}
