using PavilionsWPF.data.entity;
using PavilionsWPF.View.ShoppingMall;
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

namespace PavilionsWPF.ShoppingMall.SMList
{
    /// <summary>
    /// Логика взаимодействия для SMList.xaml
    /// </summary>
    public partial class SMList : Page
    {
        public static DataGrid dataGrid;
        public SMList()
        {
            InitializeComponent();
            myDataGrid.ItemsSource = db_PavilionsEntities.GetContext().shops_centers.ToList();
            dataGrid = myDataGrid;
        }

        
        private void GoPavilions_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Pavilions());
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
