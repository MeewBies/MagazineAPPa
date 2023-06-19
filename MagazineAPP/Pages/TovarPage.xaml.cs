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
    /// Логика взаимодействия для TovarPage.xaml
    /// </summary>
    public partial class TovarPage : Page
    {
        public TovarPage()
        {
            InitializeComponent();
            dgTrash.ItemsSource = DB.c.con.Товар.ToList();
        }

        private void Btn_trash_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TrashCan());
        }

        private void addKorz_Click(object sender, RoutedEventArgs e)
        {
            var tovar = dgTrash.SelectedItem as DB.Товар;
            var korzina = DB.c.con.Корзина.FirstOrDefault(i => i.ID_Пользователь == dannie.userID);
            var tovar_korz = new DB.Товар_корзина();
            tovar_korz.ID_Товар = tovar.ID;
            tovar_korz.ID_Корзина = korzina.ID;
            tovar_korz.Колличество = 1;
            tovar_korz.Цена = tovar.Цена;
            var prov = DB.c.con.Товар_корзина.FirstOrDefault(i => i.ID_Товар != tovar_korz.ID_Товар && i.Корзина.ID_Пользователь != dannie.userID);
            if (prov == null)
            {
                DB.c.con.Товар_корзина.Add(tovar_korz);
                DB.c.con.SaveChanges();
            }
            else MessageBox.Show("Данный товар уже в корзине");
        }
    }
}
