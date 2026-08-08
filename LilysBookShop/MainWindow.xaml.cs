using LilysBookShop.ViewModels;
using System.Windows;

namespace LilysBookShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
        }

        private void New()
        {
            // skapa nytt dokument
        }
    }
}