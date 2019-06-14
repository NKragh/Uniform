using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Handler;
using UniformApp.View;
using UniformApp.ViewModel;

namespace UniformApp.Model
{
    class ProcessOrderCatalog
    {
        private ProcessOrder _targetProcessOrder;
        public ProcessOrder TargetProcessOrder
        {
            get { return _targetProcessOrder; }
            set { _targetProcessOrder = value; }
        }

        private static ProcessOrderCatalog _instance = new ProcessOrderCatalog();

        public static ProcessOrderCatalog Instance
        {
            get => _instance;
        }

        public ObservableCollection<ProcessOrder> ProcessOrderList { get; set; }

        public ProcessOrderCatalog()
        {
            ProcessOrderList = new ObservableCollection<ProcessOrder>();
            TargetProcessOrder = new ProcessOrder();
            LoadProcessOrdersAsync();
        }

        public async void LoadProcessOrdersAsync()
        {
            int checkme = ProcessOrderPage.ColumnChoice;
            var processOrders = await Persistency.PersistencyService.ReadObjectsFromDatabaseAsync<ProcessOrder>("ProcessOrder");
            if (processOrders.Count != 0)
            {
                IEnumerable<ProcessOrder> ps = processOrders.Where(c => c.ColumnNo == 12 && !c.IsComplete); //TODO columnChoice virker ikke -.-
                foreach (var p in ps)
                {
                    ProcessOrderList.Add(p);
                }
            }
            else
            {
                ProcessOrderList.Add(new ProcessOrder(2, "2", true, 2, 2, 2));
                ProcessOrderList.Add(new ProcessOrder(1, "1", true, 1, 1, 1));
            }
        }
    }
}

