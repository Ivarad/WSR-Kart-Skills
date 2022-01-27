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
    /// Логика взаимодействия для DetailedInfromation.xaml
    /// </summary>
    public partial class DetailedInfromation : Window
    {
        public DetailedInfromation()
        {
            InitializeComponent();
        }

        private void Button_ToCharitiesList(object sender, RoutedEventArgs e)
        {
            CharitableOraganizationsList charities = new CharitableOraganizationsList();
            charities.Show();
            this.Close();
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
