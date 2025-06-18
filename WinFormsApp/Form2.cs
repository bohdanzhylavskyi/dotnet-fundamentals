using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form2 : Form
    {
        public Form2(string greetingMessage)
        {
            InitializeComponent();
            label1.Text = greetingMessage;

            PositionLabelAtTheScreenCenter(label1, -40);
        }

        private void PositionLabelAtTheScreenCenter(Label label, int verticalOffset)
        {
            label.Left = (this.ClientSize.Width - label.Width) / 2;
            label.Top = (this.ClientSize.Height - label.Height) / 2 + verticalOffset;
        }
    }
}
