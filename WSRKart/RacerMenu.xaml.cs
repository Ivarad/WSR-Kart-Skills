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

namespace WSRKart
{
    /// <summary>
    /// Логика взаимодействия для RacerMenu.xaml
    /// </summary>
    public partial class RacerMenu : Window
    {
        public RacerMenu()
        {
            InitializeComponent();
        }

        private void Button_Contacts(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Logout(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
