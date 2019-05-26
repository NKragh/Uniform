using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class CompleteCheckViewCatalog
    {
        private CompleteCheckView _targetCompleteCheckView;

        public CompleteCheckView TargetCompleteCheckView
        {
            get { return _targetCompleteCheckView; }
            set { _targetCompleteCheckView = value; }
        }

        private static CompleteCheckViewCatalog _instance = new CompleteCheckViewCatalog();

        public static CompleteCheckViewCatalog Instance
        {
            get => _instance;
        }

        public ObservableCollection<CompleteCheckView> CheckList { get; set; }

        public CompleteCheckViewCatalog()
        {
            CheckList = new ObservableCollection<CompleteCheckView>();
            TargetCompleteCheckView = new CompleteCheckView();
            LoadCompleteCheckViewsAsync();
        }

        private async void LoadCompleteCheckViewsAsync()
        {
            var checks = await Persistency.PersistencyService.ReadObjectsFromDatabaseAsync<CompleteCheckView>("CompleteCheckView");

            if (checks.Count != 0)
            {
                foreach (var c in checks)
                {
                    CheckList.Add(c);
                }
            }
            else
            {
                CheckList.Add(new CompleteCheckView("defaultProduct1", 123,456,789,123456789,"defaultBatch1",098,765));
                CheckList.Add(new CompleteCheckView("defaultProduct2", 123,456,789,123456789,"defaultBatch2",098,765));
            }
        }
    }
}
