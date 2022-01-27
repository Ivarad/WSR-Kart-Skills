using System;
using System.Collections.Generic;
using System.Data;
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
        public ThanksForSupport(string cost, DataTable row)
        {
            InitializeComponent();
            LabelRacer.Text = LabelOrganizationName.Text = row.Rows[0][1].ToString().Substring(0, row.Rows[0][1].ToString().IndexOf('|'));
            LabelCost.Text = cost;
            LabelOrganizationName.Text = LabelOrganizationName.Text = row.Rows[0][1].ToString().Remove(0, row.Rows[0][1].ToString().IndexOf('|') + 2);
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
