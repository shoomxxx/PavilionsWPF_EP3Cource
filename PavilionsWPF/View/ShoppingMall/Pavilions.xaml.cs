using PavilionsWPF.data.entity;
using PavilionsWPF.ShoppingMall.SMList;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PavilionsWPF.View.ShoppingMall
{
    /// <summary>
    /// Логика взаимодействия для Pavilions.xaml
    /// </summary>
    public partial class Pavilions : Page
    {
        public Pavilions()
        {
            InitializeComponent();
            var currentPavilions = db_PavilionsEntities.GetContext().pavilions.ToList();
            myDataGrid.ItemsSource = currentPavilions;

        }

        private void GoSMList_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new SMList());
        }
    }
}
