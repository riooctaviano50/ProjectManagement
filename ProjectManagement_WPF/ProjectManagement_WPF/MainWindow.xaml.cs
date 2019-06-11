using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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

namespace ProjectManagement_WPF
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_SignIn_Click(object sender, RoutedEventArgs e)
        {
            int flag = 0;

            if (txb_email.Text.Trim().Length == 0)
            {
                flag = 0;
                txb_email.Text = "Required";
                txb_email.Focus();
            }
            else if (!Regex.IsMatch(txb_email.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}"))
            {
                flag = 0;
                txb_email.Text = "Invalid";
                txb_email.Focus();
            }
            else
            {
                flag = 1;
                txb_email.Text = "";
            }
            if (passwordBox.Password.Trim().Length == 0)
            {
                flag = 0;
                passwordBox.Password = "Required";
                passwordBox.Focus();
            }
            if (flag == 1)
            {
                
            }
        }



        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("Your Message has been successfully sent.", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }

        
    }
