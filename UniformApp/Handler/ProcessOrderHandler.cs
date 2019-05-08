using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class ProcessOrderHandler
    {
        public ProcessOrderViewModel ProcessOrderViewModel { get; set; }

        public ProcessOrderHandler(ProcessOrderViewModel viewModel)
        {
            ProcessOrderViewModel = viewModel;
        }
        
        public bool CreateProcessOrder()
        {
            return true;
        }

        public bool DeleteProcessOrder()
        {
            return true;
        }

        public bool EditProcessOrder()
        {
            return true;
        }
    }
}
