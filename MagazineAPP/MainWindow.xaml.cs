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

namespace MagazineAPP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Pages.TovarPage());
        }

        private void Btn_vhod_Click(object sender, RoutedEventArgs e)
        {
            if (Btn_vhod.Content == "Войти")
            {
                ProjectWin.AuthWin win = new ProjectWin.AuthWin();
                win.ShowDialog();
                if (dannie.userID != 0)
                {
                    var user = DB.c.con.Пользователь.FirstOrDefault(i => i.ID == dannie.userID);
                    Btn_vhod.Content = "Выйти";
                    LablaText.Text = $"Здравствуйте, {user.ФИО}!卐";
                    MainFrame.Navigate(new Pages.TovarPage());
                }
            }
            else
            {
                Btn_vhod.Content = "Войти";
                LablaText.Text = $"Здравствуйте, Гость!卐";
                dannie.userID = 0;
                MainFrame.Navigate(new Pages.TovarPage());
            }
        }
    }
}
