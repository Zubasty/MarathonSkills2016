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
    /// Логика взаимодействия для RegisterRunnerWindow.xaml
    /// </summary>
    public partial class RegisterRunnerWindow : Window
    {
        public RegisterRunnerWindow()
        {
            InitializeComponent();
        }

        private void Cancel_B_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }

        private void Registration_B_Click(object sender, RoutedEventArgs e)
        {
            RegisterForAnEvent window = new RegisterForAnEvent();
            window.Show();
            Close();
        }
    }
}
