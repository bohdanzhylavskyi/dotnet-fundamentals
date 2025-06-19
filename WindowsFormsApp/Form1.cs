using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreetingMessageFormatterLib;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            submitBtn.Enabled = false;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            submitBtn.Enabled = !string.IsNullOrEmpty(usernameTextBox.Text.Trim());
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var username = usernameTextBox.Text.Trim();
            var greetingMessage = GreetingMessageFormatter.FormatGreetingMessage(username);

            ResetForm();

            var form2 = new Form2(greetingMessage);

            form2.ShowDialog();
        }

        private void ResetForm()
        {
            usernameTextBox.Text = "";
            submitBtn.Enabled = false;
        }
    }
}
