using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class ProcessOrderHandler
    {
        public ProcessOrderViewModel ProcessOrderProcessOrderViewModel { get; set; }

        public ProcessOrderHandler(ProcessOrderViewModel processOrderViewModel)
        {
            ProcessOrderProcessOrderViewModel = processOrderViewModel;
        }

        public void CreateProcessOrder()
        {
            Debug.WriteLine("Its Working.gif!");
        }
    }
}
