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

namespace MarathonSkills2016
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void IWantRun_B_Click(object sender, RoutedEventArgs e)
        {
            RegisterRunner window = new RegisterRunner();
            window.Show();
            Close();        
        }

        private void Login_B_Click(object sender, RoutedEventArgs e)
        {
            Login window = new Login();
            window.Show();
            Close();
        }

        private void IWantSponsor_B_Click(object sender, RoutedEventArgs e)
        {
            SponsorARunner window = new SponsorARunner();
            window.Show();
            Close();
        }
    }
}
