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

namespace MarathonSkills2016
{
    /// <summary>
    /// Логика взаимодействия для RegisterForAnEvent.xaml
    /// </summary>
    public partial class RegisterForAnEvent : Window
    {
        public RegisterForAnEvent()
        {
            InitializeComponent();
        }

        private void LogOut_B_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }

        private void Register_B_Click(object sender, RoutedEventArgs e)
        {
            RegistrationConfirmation window = new RegistrationConfirmation();
            window.Show();
            Close();
        }

        private void Cancel_B_Click(object sender, RoutedEventArgs e)
        {
            RunnerMenu window = new RunnerMenu();
            window.Show();
            Close();
        }
    }
}
