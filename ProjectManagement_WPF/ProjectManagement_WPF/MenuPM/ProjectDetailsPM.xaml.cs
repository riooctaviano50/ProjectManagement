<<<<<<< HEAD
﻿using BussinessLogic.Service;
using BussinessLogic.Service.Application;
using Common.Repository;
using Common.Repository.Application;
using ProjectManagement_WPF.MenuPM.TabMenuProjectDetailPM;
=======
﻿using ProjectManagement_WPF.MenuMember;
>>>>>>> remotes/origin/Farin
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

namespace ProjectManagement_WPF.MenuPM
{
    /// <summary>
    /// Interaction logic for ProjectDetailsPM.xaml
    /// </summary>
    public partial class ProjectDetailsPM : UserControl
    {
        public ProjectDetailsPM()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);
            UserControl usc = null;
            GridMain.Children.Clear();

            GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);

            switch (index)
            {
                case 0:
                    GridMain.Background = Brushes.CadetBlue;
                    break;
                case 1:
<<<<<<< HEAD
                    usc = new TabProjectDetailMember();
=======
                    usc = new CreateProjectMember();
>>>>>>> remotes/origin/Farin
                    GridMain.Children.Add(usc);
                    break;
                case 2:
                    GridMain.Background = Brushes.Yellow;
                    break;
                case 3:
                    GridMain.Background = Brushes.DarkBlue;
                    break;
            }
        }
    }
}
