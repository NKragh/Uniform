using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class LidCatalog
    {
        private Lid _targetLid;
        public Lid TargetLid { get => _targetLid; set => _targetLid = value; }

        private static LidCatalog _instance = new LidCatalog();
        public static LidCatalog Instance
        {
            get => _instance;
        }
        public ObservableCollection<Lid> LidList { get; set; }

        public LidCatalog()
        {
            LidList = new ObservableCollection<Lid>();
            TargetLid = new Lid();
            LoadLidsAsync();
        }

        private async void LoadLidsAsync()
        {
            var products = await Persistency.PersistencyService.ReadObjectsFromDatabaseAsync<Lid>("Lid");
            if (products.Count != 0)
            {
                foreach (var product in products)
                {
                    LidList.Add(product);
                }
            }
            else
            {
                LidList.Add(new Lid(1020, 10,20,30));
                LidList.Add(new Lid(1111, 20,30,40));
            }
        }
    }
}
