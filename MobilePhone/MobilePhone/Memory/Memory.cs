namespace SimCorp.IMS.Memory
{
    internal abstract class Memory
    {
        protected Memory(float capacity)
        {
            Capacity = capacity;
        }

        protected Memory()
        {

        }

        public abstract void Read();
        public float Capacity { get; private set; } = 500;
    }
}
