using BussinessLogic.Service;
using BussinessLogic.Service.Application;
using Common.Repository.Application;
using DataAccess.Context;
using DataAccess.ViewModels;
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
using System.Windows.Shapes;

namespace ProjectManagement_WPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        MyContext myContext = new MyContext();

        public Login()
        {
            InitializeComponent();
        }
        

        private void btn_SignIn_Click(object sender, RoutedEventArgs e)
        {
            SetLogin();            
        }

        private void SetLogin()
        {
            LoginRepository loginRepository = new LoginRepository();
            if (loginRepository.CheckLogin(txb_email.Text, passwordBox.Password) == true)
            {
                this.Hide();
                if (loginRepository.CheckAdmin(txb_email.Text, passwordBox.Password) == true)
                {
                    ProjectManager projectManager = new ProjectManager();
                    projectManager.Show();
                }
                else
                {
                    DashboardMember dashboardMember = new DashboardMember();
                    dashboardMember.Show();
                }
            }
            else
            {
                MessageBox.Show("Login Failed", "Warning!", MessageBoxButton.OK, MessageBoxImage.Information);
                passwordBox.Clear();
                passwordBox.Focus();
            }
        }
    }
}
