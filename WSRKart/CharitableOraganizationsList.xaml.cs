using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для CharitableOraganizationsList.xaml
    /// </summary>
    public partial class CharitableOraganizationsList : Window
    {
        public CharitableOraganizationsList()
        {
            InitializeComponent();

            SqlConnection connection = new SqlConnection(Constants.connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"select [Charity_Name], [Charity_Description], [Charity_Logo] from Charity",connection);
            DataSet data = new DataSet();
            dataAdapter.Fill(data);
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                CharityList.Children.Add(new CharityInfoUserControl(data.Tables[0].Rows[i][2].ToString(), data.Tables[0].Rows[i][0].ToString(), data.Tables[0].Rows[i][1].ToString()));
            }
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
            DetailedInfromation infromation = new DetailedInfromation();
            infromation.Show();
        }
    }
}
