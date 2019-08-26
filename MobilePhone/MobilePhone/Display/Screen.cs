using System.Dynamic;
using System.Text;

namespace SimCorp.IMS.Display
{
    internal abstract class Screen
    {
        protected Screen(float diagonal)
        {
            Diagonal = diagonal;
        }

        public abstract void Show(IScreenImage screenImage);
        public abstract void Show(IScreenImage screenImage, int brightness);

        public override string ToString()
        {
            var screenDescription = new StringBuilder();
            screenDescription.AppendLine($"Diagonal is {Diagonal}");
            screenDescription.AppendLine($"Screen Resolution: {Resolution}");
            screenDescription.AppendLine($"Color depth: {ColorDepth}");
            screenDescription.Append("DPI: " + Resolution.calculateDpi(Diagonal));
            return screenDescription.ToString();
        }

        public float Diagonal { get; protected set; }
        public int ColorDepth { get; protected set; }
        public virtual ScreenResolution Resolution { get;}=new ScreenResolution(720,1280);
    }
}
