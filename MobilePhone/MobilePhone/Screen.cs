using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    internal abstract class Screen
    {
        protected Screen(float diagonal)
        {
            Diagonal = diagonal;
        }

        public float Diagonal { get; protected set; }
        public abstract void Show(IScreenImage screenImage);
        public abstract void Show(IScreenImage screenImage, int brightness);
        public override string ToString()
        {
            return $"Diagonal is {Diagonal}";
        }
    }
}
