using BussinessLogic.Service;
using BussinessLogic.Service.Application;
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

namespace ProjectManagement_WPF.MenuPM.TabMenuProjectDetailPM
{
    /// <summary>
    /// Interaction logic for TabProjectDetailMember.xaml
    /// </summary>
    public partial class TabProjectDetailMember : UserControl
    {
        IRuleService iRuleService = new RuleService();

        public TabProjectDetailMember()
        {
            InitializeComponent();
        }

        #region Load Section
        private void LoadCombo()
        {
            cmb_Rule.ItemsSource = iRuleService.Get();
        }
        #endregion Load Section

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCombo();
        }
    }
}