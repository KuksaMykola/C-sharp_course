using System;

namespace SimCorp.IMS.MobilePhone.Display
{
    internal class ScreenResolution
    {
        public ScreenResolution(int horizontalPixels,int verticalPixels )
        {
            HorizontalPixels = horizontalPixels;
            VerticalPixels = verticalPixels;
        }

        public int calculateDpi(float screenDiagonal)
        {
          var diagonalPixels = Math.Sqrt(Math.Pow(HorizontalPixels,2)+Math.Pow(VerticalPixels,2));
          var dpi = (int) Math.Round(diagonalPixels/screenDiagonal);
          return dpi;
        }

        public override string ToString()
        {
            return $"{HorizontalPixels}x{VerticalPixels}";
        }

        private int HorizontalPixels;
        private int VerticalPixels;
    }
}
