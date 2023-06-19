using IronPdf;
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

namespace MagazineAPP.Pages
{
    /// <summary>
    /// Логика взаимодействия для TrashCan.xaml
    /// </summary>
    public partial class TrashCan : Page
    {
        public TrashCan()
        {
            InitializeComponent();
            dgTrash.ItemsSource = DB.c.con.Товар_корзина.ToList();
            moneycash.Text = DB.c.con.Корзина.FirstOrDefault(i => i.ID_Пользователь == dannie.userID).Общая_сумма.ToString();
        }

        private void addTovar_Click(object sender, RoutedEventArgs e)
        {
            var tovar = dgTrash.SelectedItem as DB.Товар_корзина;
            var mon = DB.c.con.Товар.FirstOrDefault(i => i.ID == tovar.ID_Товар);
            int money = mon.Цена;
            tovar.Цена += money;
            var trash = DB.c.con.Корзина.FirstOrDefault(i => i.ID_Пользователь == dannie.userID);
            trash.Общая_сумма += money;
            tovar.Колличество += 1;
            DB.c.con.SaveChanges();
            moneycash.Text = DB.c.con.Корзина.FirstOrDefault(i => i.ID_Пользователь == dannie.userID).Общая_сумма.ToString();
            dgTrash.ItemsSource = DB.c.con.Товар_корзина.ToList();
        }

        private void removeTovar_Click(object sender, RoutedEventArgs e)
        {
            var tovar = dgTrash.SelectedItem as DB.Товар_корзина;
            var mon = DB.c.con.Товар.FirstOrDefault(i => i.ID == tovar.ID_Товар);
            int money = mon.Цена;
            var trash = DB.c.con.Корзина.FirstOrDefault(i => i.ID_Пользователь == dannie.userID);
            
            if (tovar.Колличество != 1)
            {
                tovar.Колличество -= 1;
                trash.Общая_сумма -= money;
                tovar.Цена -= money;
                DB.c.con.SaveChanges();
                moneycash.Text = DB.c.con.Корзина.FirstOrDefault(i => i.ID_Пользователь == dannie.userID).Общая_сумма.ToString();
                dgTrash.ItemsSource = DB.c.con.Товар_корзина.ToList();
            }
        }

        private void removeTovar_Click_1(object sender, RoutedEventArgs e)
        {
            var tovar = dgTrash.SelectedItem as DB.Товар_корзина;
            var trash = DB.c.con.Корзина.FirstOrDefault(i => i.ID_Пользователь == dannie.userID);
            trash.Общая_сумма -= tovar.Цена;
            DB.c.con.Товар_корзина.Remove(tovar);
            DB.c.con.SaveChanges();
            moneycash.Text = DB.c.con.Корзина.FirstOrDefault(i => i.ID_Пользователь == dannie.userID).Общая_сумма.ToString();
            dgTrash.ItemsSource = DB.c.con.Товар_корзина.ToList();
        }

        private void pdfButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void fuckGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TovarPage());
        }
    }
}
