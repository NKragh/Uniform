using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Handler;
using UniformApp.ViewModel;

namespace UniformApp.Model
{
    class ProcessOrderCatalog
    {
        private static ProcessOrderCatalog _instance = new ProcessOrderCatalog();

        public static ProcessOrderCatalog Instance
        {
            get => _instance;
        }

        public ObservableCollection<ProcessOrder> ProcessOrderList { get; set; }

        public ProcessOrderCatalog()
        {
            ProcessOrderList = new ObservableCollection<ProcessOrder>();
            LoadProcessOrdersAsync();
        }

        private async void LoadProcessOrdersAsync()
        {
            var processOrders = await Persistency.PersistencyService
                .ReadProcessOrder<ProcessOrder>();
            if (processOrders.Count != 0)
            {
                foreach (var p in processOrders)
                {
                    ProcessOrderList.Add(p);
                }
            }
            else
            {
                ProcessOrderList.Add(new ProcessOrder(1,DateTime.Now,"1",true,1,1,1));
                ProcessOrderList.Add(new ProcessOrder(2, DateTime.Now, "2", true, 2, 2, 2));
            }
        }
    }
}

