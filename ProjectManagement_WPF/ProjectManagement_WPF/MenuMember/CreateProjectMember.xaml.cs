using BussinessLogic.Service;
using BussinessLogic.Service.Application;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectManagement_WPF.MenuMember
{
    /// <summary>
    /// Interaction logic for CreateProjectMember.xaml
    /// </summary>
    public partial class CreateProjectMember : UserControl
    {
        IProjectService iProjectService = new ProjectService();
        ProjectVM projectVM = new ProjectVM();
        IStatusService IStatusVM = new StatusService();
        StatusVM statusVM = new StatusVM();
        public CreateProjectMember()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(txb_Name.Text != "")
            {
                if(date_Start.Text != "")
                {
                    if(date_Due.Text != "")
                    {
                        if(txb_DetailProject.Text != "")
                        {
                            projectVM.Name = txb_Name.Text;
                            projectVM.ProjectStart = Convert.ToDateTime(date_Start.Text);
                            projectVM.ProjectDeadline = Convert.ToDateTime(date_Due.Text);
                            projectVM.ProjectDetails = txb_DetailProject.Text;
                            var result = iProjectService.Insert(projectVM); //Save Project
                            if (result)
                            {
                                MessageBox.Show("Insert Succesfully");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Detail Project not inputted");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Due date not defined");
                    }
                }
                else
                {
                    MessageBox.Show("Start date not defined");
                }
            }
            else
            {
                MessageBox.Show("Name Project must be inputted");
            }
        }
    }
}
