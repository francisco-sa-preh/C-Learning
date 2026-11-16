using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InvoiceManagement
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public void OnLoginBtnClicked(object sender, RoutedEventArgs e)
        {
            var passwordEntered = PasswordBox.Password;
            string? envPw = Environment.GetEnvironmentVariable("InvoiceManagement");

            if (envPw != null)
            {
                if (envPw == passwordEntered)
                {
                    MessageBox.Show("Correct password");
                }
                else
                {
                    MessageBox.Show("Incorrect password");
                }
            }
            else 
            {
                MessageBox.Show("Environmental variable not found");
            }

        }

        public void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty(PasswordBox.Password);
        }
    }
}
