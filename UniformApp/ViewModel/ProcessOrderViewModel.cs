using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UniformApp.Handler;

namespace UniformApp.ViewModel
{
    class ProcessOrderViewModel : INotifyPropertyChanged
    {
        public ICommand CreateProcessOrderCommand { get; set; }
        public ICommand DeleteProcessOrderCommand { get; set; }
        public ICommand EditProcessOrderCommand { get; set; }
        public ICommand SaveProcessOrderCommand { get; set; }

        public ProcessOrderViewModel()
        {
            ProcessOrderHandler poHandler = new ProcessOrderHandler(this);

            //relaycommands
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
