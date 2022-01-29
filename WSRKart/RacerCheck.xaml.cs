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
    /// Логика взаимодействия для RacerCheck.xaml
    /// </summary>
    public partial class RacerCheck : Window
    {
        public RacerCheck()
        {
            InitializeComponent();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_To_Authorization(object sender, RoutedEventArgs e)
        {
            this.Close();
            AuthorizationMenu authorization = new AuthorizationMenu();
            authorization.Show();
        }

        private void Button_ToRegistration(object sender, RoutedEventArgs e)
        {
            this.Close();
            RacerRegistration registration = new RacerRegistration();
            registration.Show();
        }
    }
}
