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
    /// <summary>
    /// Логика взаимодействия для CharityInfoUserControl.xaml
    /// </summary>
    public partial class CharityInfoUserControl : UserControl
    {
        public CharityInfoUserControl(string path, string nameOrganization, string description)
        {
            InitializeComponent();
            BitmapImage image = new BitmapImage(new Uri("/WSRKart;component/Logos/"+path, UriKind.Relative));
            Logo.Source = image;
            NameOrganization.Text = nameOrganization;
            Description.Text = description;
        }
    }
}
