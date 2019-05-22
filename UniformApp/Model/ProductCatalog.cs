using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class ProductCatalog
    {
        private Product _targetProduct;
        public Product TargetProduct
        {
            get { return _targetProduct; }
            set { _targetProduct = value; }
        }

        private static ProductCatalog _instance = new ProductCatalog();

        public static ProductCatalog Instance
        {
            get => _instance;
        }

        public ObservableCollection<Product> ProductList { get; set; }

        public ProductCatalog()
        {
            ProductList = new ObservableCollection<Product>();
            LoadProductsAsync();
        }

        private async void LoadProductsAsync()
        {
            var products = await Persistency.PersistencyService.ReadObjectsFromDatabaseAsync<Product>("Product");
            if (products.Count != 0)
            {
                foreach (var p in products)
                {
                    ProductList.Add(p);
                }
            }
            else
            {
                ProductList.Add(new Product(1, "Default01", true, "isfluid", 10, 20, 30));
                ProductList.Add(new Product(2, "Default02", true, "isfluid", 10, 20, 30));
            }
        }
    }
}
