using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;


namespace WSRKart
{
    public partial class SponsorRider : Window
    {
        DataSet data = new DataSet();
        public SponsorRider()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(Constants.connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"select concat([First_Name], ' ', [Last_Name], ' - ', dbo.Racer.ID_Racer, ' (',[Country_Name], ')') as 'ForCombobox', " +
                $"concat([First_Name], ' ', [Last_Name], ' - ', dbo.Racer.ID_Racer, ' (',[Country_Name], ') | ',[Charity_Name]) as 'Value' " +
                $"from Racer inner join Country on Country.ID_Country = Racer.ID_Country inner join Registration on Registration.ID_Racer = Racer.ID_Racer inner " +
                $"join Charity on Charity.ID_Сharity = Registration.ID_Charity",connection);
            
            dataAdapter.Fill(data);
            
            Racer.ItemsSource = data.Tables[0].DefaultView;
            Racer.SelectedValuePath = "Value";
            Racer.DisplayMemberPath = "ForCombobox";
            
            connection.Close();
        }

        private void Button_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Pay(object sender, RoutedEventArgs e)
        {
            if(Name.Text == "")
            {
                MessageBox.Show("Поле имени не должно быть пустым!");
            }
            else if (Racer.SelectedIndex < 0)
            {
                MessageBox.Show("В списке необходимо выбрать гонщика!");
            }
            else if (CardholderName.Text == "")
            {
                MessageBox.Show("Поле имени владельца карты не должно быть пустым!");
            }
            else if (CardNumber.Text.Length < 16)
            {
                MessageBox.Show("Поле номера карты не должно быть пустым!");
            }
            else if (DateTime.Now.Year > Convert.ToInt32(Year.Text))
            {
                MessageBox.Show("Истек срок действия карты!");
            }
            else if (CVC.Text.Length < 3)
            {
                MessageBox.Show("Неправильный CVC код!");
            }
            else if (Convert.ToInt32(Cost.Text) < 10)
            {
                MessageBox.Show("Нельзя внести сумму меньше 10$!");
            }
            else
            {
                DataTable result = (data.Tables[0].AsEnumerable().Where(myRow => myRow.Field<string>("Value") == Racer.SelectedValue.ToString())).CopyToDataTable();
                ThanksForSupport forSupport = new ThanksForSupport(LabelCost.Text, (data.Tables[0].AsEnumerable().Where(myRow => myRow.Field<string>("Value") == Racer.SelectedValue.ToString())).CopyToDataTable());
                forSupport.Show();
                this.Hide();
            }
        }

        private void Button_Decrease(object sender, RoutedEventArgs e)
        {
            if(Convert.ToInt32(Cost.Text) > 0)
            Cost.Text = (Convert.ToInt32(Cost.Text) - 10).ToString();
        }

        private void Button_Crease(object sender, RoutedEventArgs e)
        {
            if(Convert.ToInt32(Cost.Text) < Int32.MaxValue)
            Cost.Text = (Convert.ToInt32(Cost.Text) + 10).ToString();
        }

        private void TexboxCost_CostChanged(object sender, TextChangedEventArgs e)
        {
            if(Cost.Text != "")
            LabelCost.Text = "$ " + Cost.Text;
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Racer_ValueChanged(object sender, EventArgs e)
        {
            DataTable result = (data.Tables[0].AsEnumerable().Where(myRow => myRow.Field<string>("Value") == Racer.SelectedValue.ToString())).CopyToDataTable();
            if (result.Rows.Count > 0)
            LabelOrganizationName.Text = result.Rows[0][1].ToString().Remove(0, result.Rows[0][1].ToString().IndexOf('|')+2);
        }
    }
}
