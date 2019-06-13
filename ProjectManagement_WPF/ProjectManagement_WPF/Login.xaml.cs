using BussinessLogic.Service;
using BussinessLogic.Service.Application;
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
        ILoginService iLoginService = new LoginService();
        EmployeeVM emplpoyeeVM = new EmployeeVM();
        MyContext myContext = new MyContext();

        public Login()
        {
            InitializeComponent();
            Init_Data();
        }

        private void Init_Data()
        {
            throw new NotImplementedException();
        }

        private void btn_SignIn_Click(object sender, RoutedEventArgs e)
        {
            string email = txb_email.Text;
            string password = passwordBox.Password;

            var get = myContext.Employees.Where
            (x => (x.Email.Contains(email) &&
            x.Password.Contains(password))).SingleOrDefault();
            int count = Convert.ToInt32(myContext.GetValidationErrors());
            if (count == 1)
            {
                
            }
            else
            {
                MessageBox.Show("Email or Password is Correct");
            }
            
        }
    }
}
