namespace SimCorp.IMS.MobilePhone.Audio
{
    class ExternalPhoneSpeaker:IPlayback
    {
        public void Play(object data)
        {
            System.Console.WriteLine($"{nameof(ExternalPhoneSpeaker)} sound");
        }
    }
}
