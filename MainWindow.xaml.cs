using System.ComponentModel;
using System.Windows;

namespace classwork25._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        BindingList<Purchase> purchasesList;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            purchasesList = new BindingList<Purchase>()
            {
                new Purchase() { Name = "какой то товар 1", Price = "1", Count = "10"},
                new Purchase() { Name = "какой то товар 2", Price = "2", Count = "11"},
                new Purchase() { Name = "какой то товар 3", Price = "3", Count= "12"}

            };

            Product.ItemsSource = purchasesList;
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            while (Product.SelectedItem != null)
            {
                purchasesList.Remove((Purchase)Product.SelectedItem);
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            purchasesList.Add(new Purchase() { Name = newName.Text, Price = newPrice.Text, Count = newCount.Text });
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            purchasesList.Clear();
        }

        private void Sel_Click(object sender, RoutedEventArgs e)
        {
            Product.SelectAll();
        }
    }
}
