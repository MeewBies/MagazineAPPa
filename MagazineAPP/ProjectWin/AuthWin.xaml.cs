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

namespace MagazineAPP.ProjectWin
{
    /// <summary>
    /// Логика взаимодействия для AuthWin.xaml
    /// </summary>
    public partial class AuthWin : Window
    {
        public AuthWin()
        {
            InitializeComponent();
        }

        private void logButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user = DB.c.con.Пользователь.FirstOrDefault(i => i.Логин == logBox.Text && i.Пароль == pasBox.Password);
                if (user != null)
                {
                    dannie.userID = user.ID;
                    MessageBox.Show("Добро пожаловать");
                    Close();
                }
                else MessageBox.Show("Лох");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сисимасиси {ex}");
            }
        }
    }
}
