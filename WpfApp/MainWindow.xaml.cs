using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreetingMessageFormatterLib;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            submitBtn.IsEnabled = false;
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            var username = usernameTextBox.Text.Trim();
            var greetingMessage = GreetingMessageFormatter.FormatGreetingMessage(username);

            ResetForm();

            var greetingMessageWindow = new GreetingMessageWindow(greetingMessage);
            greetingMessageWindow.ShowDialog();
        }

        private void ResetForm()
        {
            usernameTextBox.Text = "";
            submitBtn.IsEnabled = false;
        }

        private void UsernameTextBox_Change(object sender, TextChangedEventArgs e)
        {
            submitBtn.IsEnabled = !string.IsNullOrEmpty(usernameTextBox.Text.Trim());
        }
    }
}
