using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class PreformCatalog
    {
        private Preform _targetPreform;
        public Preform TargetPreform
        {
            get { return _targetPreform; }
            set { _targetPreform = value; }
        }

        private static PreformCatalog _instance = new PreformCatalog();

        public static PreformCatalog Instance
        {
            get => _instance;
        }

        public ObservableCollection<Preform> PreformList { get; set; }

        public PreformCatalog()
        {
            PreformList = new ObservableCollection<Preform>();
            TargetPreform = new Preform();
            LoadPreformsAsync();
        }

        private async void LoadPreformsAsync()
        {
            var products = await Persistency.PersistencyService.ReadObjectsFromDatabaseAsync<Preform>("Preform");
            if (products.Count != 0)
            {
                foreach (var p in products)
                {
                    PreformList.Add(p);
                }
            }
            else
            {
                PreformList.Add(new Preform(123456, 50, 12.5, 10, 20, "Resilux"));
                PreformList.Add(new Preform(654312, 50, 12.5, 20, 30, "Petainer"));
            }
        }
    }
}
