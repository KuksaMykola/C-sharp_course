using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Test
{
    class FakeOutput : IOutput
    {
        public string WrittenText { get; private set; }

        public void Write(string text)
        {
            WrittenText = text;
        }

        public void WriteLine(string text)
        {
            WrittenText = text;
        }
    }
}
