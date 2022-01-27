﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;


namespace WSRKart
{
    public partial class SponsorRider : Window
    {

        public SponsorRider()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(Constants.connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"select [First_Name], [Last_Name], [ID_Racer], [Country_Name]  from Racer inner join Country on Country.ID_Country = Racer.ID_Country",connection);
            DataSet data = new DataSet();
            dataAdapter.Fill(data);
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                Racer.Items.Add($"{data.Tables[0].Rows[i][0].ToString()} {data.Tables[0].Rows[i][1].ToString()} - {data.Tables[0].Rows[i][2].ToString()} ({data.Tables[0].Rows[i][3].ToString()})");
            }
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
                ThanksForSupport forSupport = new ThanksForSupport(Racer.SelectedItem.ToString(), LabelCost.Text);
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
    }
}
