namespace SimCorp.IMS.MobilePhone.Audio
{
    public class ExternalPhoneSpeaker:IPlayback
    {
        private IOutput Output;

        public ExternalPhoneSpeaker(IOutput output)
        {
            Output = output;
        }

        public void Play(object data)
        {
            Output.WriteLine($"{nameof(ExternalPhoneSpeaker)} sound");
        }

        public override string ToString()
        {
            return nameof(ExternalPhoneSpeaker);
        }
    }
}
