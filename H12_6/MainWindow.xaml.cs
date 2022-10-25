using H12_6.Base;
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

namespace H12_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Manager manager;
        Consult consult;
        public MainWindow()
        {
            InitializeComponent();
            Btn_GetCl.IsEnabled = false;
            Btn_NewCl.IsEnabled = false;
            Btn_SaveData.IsEnabled = false;
            ComboBox_1.IsEnabled = false;
        }

        private void CB_User_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CB_User.SelectedIndex == 0)
            {
                manager = new Manager(this);
                manager.ViewClientData();
                CB_User.IsEnabled = false;
                Btn_GetCl.IsEnabled = true;
                Btn_SaveData.IsEnabled = true;
                ComboBox_1.IsEnabled = true;
                Btn_NewCl.IsEnabled = true;
            }
            else if (CB_User.SelectedIndex == 1)
            {
                consult = new Consult(this);
                consult.ViewClientData();
                CB_User.IsEnabled = false;
                Btn_GetCl.IsEnabled = true;
                ComboBox_1.IsEnabled = true;
                Btn_SaveData.IsEnabled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CB_User.SelectedIndex == 0)
            {
                manager.ChangeData();
                manager.ViewClientData();
            }
            else if (CB_User.SelectedIndex == 1)
            {
                consult.ChangeData();
                consult.ViewClientData();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (CB_User.SelectedIndex == 0)
            {
                manager.ViewClientData();
            }
            else if (CB_User.SelectedIndex == 1)
            {
                consult.ViewClientData();
            }
        }


        private void Btn_AddNewClient(object sender, RoutedEventArgs e)
        {
            if (CB_User.SelectedIndex == 0)
            {
                manager.CreateNewClient();
            }
        }
    }
}
