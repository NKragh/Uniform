using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using UniformApp.Handler;

namespace UniformApp.ViewModel
{
    class ProcessOrderViewModel : INotifyPropertyChanged
    {
        public ProcessOrderHandler ProcessOrderHandler { get; set; }
       
        public ICommand CreateProcessOrderCommand { get; set; }
        public ICommand DeleteProcessOrderCommand { get; set; }
        public ICommand EditProcessOrderCommand { get; set; }
        public ICommand SaveProcessOrderCommand { get; set; }

        private ProcessOrder _newProcessOrder;

        public ProcessOrder NewProcessOrder
        {
            get { return new ProcessOrder;}
            set
            {
                _newProcessOrder = value;
                OnPropertyChanged();
            }
        }

        public ProcessOrderViewModel()
        {
            ProcessOrderHandler poHandler = new ProcessOrderHandler(this);

            CreateProcessOrderCommand = new RelayCommand (ProcessOrderHandler.CreateProcessOrder);
            DeleteProcessOrderCommand = new RelayCommand(ProcessOrderHandler.DeleteProcessOrder);
            EditProcessOrderCommand = new RelayCommand(ProcessOrderHandler.EditProcessOrder);

            ProcessOrder = NewProcessOrder();


            //relaycommands
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
