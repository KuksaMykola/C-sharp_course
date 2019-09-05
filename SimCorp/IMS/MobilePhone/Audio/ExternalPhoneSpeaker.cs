namespace SimCorp.IMS.MobilePhone.Audio
{
    public class ExternalPhoneSpeaker:IPlayback
    {
        public void Play(object data)
        {
            System.Console.WriteLine($"{nameof(ExternalPhoneSpeaker)} sound");
        }

        public override string ToString()
        {
            return nameof(ExternalPhoneSpeaker);
        }
    }
}
