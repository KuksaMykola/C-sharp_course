using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimCorp.IMS.MobilePhone;

namespace SimCorp.IMS.WindowsFormsApp
{
    class TextBoxOutput:IOutput
    {
        private TextBoxBase TextBox;
        private bool FirstLine = true;

        public TextBoxOutput(TextBoxBase textBox)
        {
            TextBox = textBox;
        }
        public void Write(string text)
        {
            TextBox.AppendText(text);
            FirstLine = false;
        }

        public void WriteLine(string text)
        {
            if (!FirstLine)
            {
                TextBox.AppendText(Environment.NewLine);
            }
            TextBox.AppendText(text);
            FirstLine = false;
        }

        public void Clear()
        {
            TextBox.Clear();
            FirstLine = true;
        }
    }
}
