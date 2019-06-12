using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class LabelCatalog
    {
        private Label _targetLabel;
        public Label TargetLabel
        {
            get { return _targetLabel; }
            set { _targetLabel = value; }
        }

        private static LabelCatalog _instance = new LabelCatalog();

        public static LabelCatalog Instance
        {
            get => _instance;
        }

        public ObservableCollection<Label> LabelList { get; set; }

        public LabelCatalog()
        {
            LabelList = new ObservableCollection<Label>();
            TargetLabel = new Label();
            LoadLabelsAsync();
        }

        private async void LoadLabelsAsync()
        {
            var products = await Persistency.PersistencyService.ReadObjectsFromDatabaseAsync<Label>("Label");
            if (products.Count != 0)
            {
                foreach (var p in products)
                {
                    LabelList.Add(p);
                }
            }
            else
            {
                LabelList.Add(new Label(1234, 4790));
                LabelList.Add(new Label(1235, 5678));
            }
        }
    }
}
