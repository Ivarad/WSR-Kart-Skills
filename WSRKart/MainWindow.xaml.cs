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

namespace WSRKart
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_To_Registration_Racer(object sender, RoutedEventArgs e)
        {

        }

        private void Button_To_Registration_Sponsor(object sender, RoutedEventArgs e)
        {
            SponsorRider sponsor = new SponsorRider();
            sponsor.Show();
        }

        private void Button_To_About(object sender, RoutedEventArgs e)
        {
            DetailedInfromation infromation = new DetailedInfromation();
            infromation.Show();
        }

        private void Button_To_Entry(object sender, RoutedEventArgs e)
        {
            AuthorizationMenu authorization = new AuthorizationMenu();
            authorization.Show();
        }
    }
}
