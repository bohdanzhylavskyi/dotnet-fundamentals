using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsLabel = System.Windows.Forms.Label;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2(string greetingMessage)
        {
            InitializeComponent();
            greetingMessageLabel.Text = greetingMessage;

            PositionLabelAtTheScreenCenter(greetingMessageLabel, -40);
        }

        private void PositionLabelAtTheScreenCenter(FormsLabel label, int verticalOffset)
        {
            label.Left = (this.ClientSize.Width - label.Width) / 2;
            label.Top = (this.ClientSize.Height - label.Height) / 2 + verticalOffset;
        }
    }
}
