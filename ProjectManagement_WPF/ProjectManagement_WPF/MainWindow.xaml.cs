using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

        private void btn_SignIn_Click(object sender, AsyncCompletedEventArgs e)
        {
            if (txb_email.Text.Length == 0)
            {
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!Regex.IsMatch(txb_email.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}"))
            {
                MessageBox.Show("Your Message has been successfully sent.", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                string email = txb_email.Text;
                string password = passwordBox.Password;
                SqlConnection con = new SqlConnection("data source = DEWIPRILIANI; initial catalog = ProjectManagement;integrated security = true");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Registration where Email = '" + email + "'  and password='" + password + "'", con);
                cmd.CommandType = CommandType.Text;  
                SqlDataAdapter adapter = new SqlDataAdapter();  
                adapter.SelectCommand = cmd;  
                DataSet dataSet = new DataSet();  
                adapter.Fill(dataSet);

                MessageBox.Show("Sorry! Please enter existing emailid/password.", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                passwordBox.Focus();
                

            }
        }
    }
}
