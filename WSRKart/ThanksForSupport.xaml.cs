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
    /// Логика взаимодействия для ThanksForSupport.xaml
    /// </summary>
    public partial class ThanksForSupport : Window
    {
        public ThanksForSupport(string Racer, string Cost)
        {
            InitializeComponent();
            LabelRacer.Text = Racer;
            LabelCost.Text = Cost;
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
