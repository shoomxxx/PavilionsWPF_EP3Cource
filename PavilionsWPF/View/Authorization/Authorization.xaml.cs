using PavilionsWPF.data.Repository;
using PavilionsWPF.ShoppingMall.SMList;
using System.Windows;
using System.Windows.Controls;

namespace PavilionsWPF.View.Authorization
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        private EfUser _repository = new EfUser();

        public Authorization(string Login = null, string Password = null)
        {
            InitializeComponent();
            this.Login.Text = Login;
            this.Password.Password = Password;

        }
        private void GoMainPg_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Login.Text) && !string.IsNullOrEmpty(Password.Password))
            {
                var user = _repository.EmployeeCheck(Login.Text, Password.Password);
                if (user != null)
                {
                    NavigationService?.Navigate(new SMList());
                }
                else
                {
                    MessageBox.Show("User not found!");
                }
            }
            else
            {
                MessageBox.Show("Places empty!");
            }
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new SMList());
        }
    }
}
