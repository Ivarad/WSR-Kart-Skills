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
    /// Логика взаимодействия для AuthorizationMenu.xaml
    /// </summary>
    public partial class AuthorizationMenu : Window
    {
        public AuthorizationMenu()
        {
            InitializeComponent();
        }

        private void Button_Authorization(object sender, RoutedEventArgs e)
        {
            if (Email.Text != "" && Password.Text != "")
            {
                SqlConnection connection = new SqlConnection(Constants.connectionString);
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"select [Email] as 'Email',[Password] as 'Password', [ID_Role] as 'Role' from [User] where Email = '{Email.Text}'", connection);
                DataSet user = new DataSet();
                dataAdapter.Fill(user);
                if (user.Tables[0].Rows.Count > 0)
                {
                    if (user.Tables[0].Rows[0][1].ToString() == Password.Text)
                    {
                        if(user.Tables[0].Rows[0][2].ToString() == "R")
                        {
                            RacerMenu racerMenu = new RacerMenu();
                            racerMenu.Show();
                        }
                        if (user.Tables[0].Rows[0][2].ToString() == "C")
                        {
                            CoordinatorMenu coordinatorMenu = new CoordinatorMenu();
                            coordinatorMenu.Show();
                        }
                        if (user.Tables[0].Rows[0][2].ToString() == "A")
                        {
                            AdministratorMenu administratorMenu = new AdministratorMenu();
                            administratorMenu.Show();
                        }
                        this.Close();
                    }
                    else MessageBox.Show("Неправильный пароль!");
                }
                else MessageBox.Show("Пользователя с такой почтой не существует!");

            }
            else MessageBox.Show("Заполните поля логина и пароля");
        }

        private void Button_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
