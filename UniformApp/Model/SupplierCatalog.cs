using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class SupplierCatalog
    {
        private Supplier _targetSupplier;

        public Supplier TargetSupplier { get => _targetSupplier; set => _targetSupplier = value; }
        private static SupplierCatalog _instance = new SupplierCatalog();

        public static SupplierCatalog Instance
        {
            get => _instance;
        }
        public ObservableCollection<Supplier> SupplierList { get; set; }

        public SupplierCatalog()
        {
            SupplierList = new ObservableCollection<Supplier>();
            TargetSupplier = new Supplier();
            LoadSuppliersAsync();
        }

        private async void LoadSuppliersAsync()
        {
            var products = await Persistency.PersistencyService.ReadObjectsFromDatabaseAsync<Supplier>("Supplier");
            if (products.Count != 0)
            {
                foreach (var product in products)
                {
                    SupplierList.Add(product);
                }
            }
            else
            {
                SupplierList.Add(new Supplier("Resilux"));
                SupplierList.Add(new Supplier("Petainer"));
            }
        }
    }
}
