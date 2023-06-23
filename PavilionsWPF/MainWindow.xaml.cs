using PavilionsWPF.View.Authorization;
using System.Windows;

namespace PavilionsWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Authorization());
        }
    }
}
