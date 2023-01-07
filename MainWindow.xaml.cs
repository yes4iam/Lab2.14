using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lab2._14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Мандарины",
                ProdPrice = 210,
                ProdImage = "Data/Мандарины.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Яблоки",
                ProdPrice = 98,
                ProdImage = "Data/Яблоки.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Пылесос",
                ProdPrice = 8590,
                ProdImage = "Data/Пылесос.jpg",
                ProductCategory = ProductCategorys.Technics
            });
            products.Add(new Product()
            {
                ProdName = "Чайник",
                ProdPrice = 3690,
                ProdImage = "Data/Чайник.jpg",
                ProductCategory = ProductCategorys.Technics
            });
            lstBox.ItemsSource = products;
        }
    }

}
