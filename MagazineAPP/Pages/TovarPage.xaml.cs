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
            if (dannie.userID != 0)
                Btn_trash.Visibility = Visibility.Visible;
            else
                Btn_trash.Visibility = Visibility.Hidden;

        }

        private void Btn_trash_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TrashCan());
        }
    }
}
