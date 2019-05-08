using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using UniformApp.Annotations;
using UniformApp.Handler;
using UniformApp.Model;

namespace UniformApp.ViewModel
{
    class ProcessOrderViewModel : INotifyPropertyChanged
    {
        public ProcessOrderHandler ProcessOrderHandler { get; set; }
       
        public ICommand CreateProcessOrderCommand { get; set; }
        public ICommand DeleteProcessOrderCommand { get; set; }
        public ICommand EditProcessOrderCommand { get; set; }
        public ICommand ReadProcessOrderCommand { get; set; }

        private ProcessOrder _newProcessOrder;
        private string path;
        public ObservableCollection<ProcessOrder> processOrders = new ObservableCollection<ProcessOrder>();

        public ProcessOrder NewProcessOrder
        {
            get { return new ProcessOrder(); }
            set
            {
                _newProcessOrder = value;
                OnPropertyChanged();
            }
        }
        
        public ProcessOrderViewModel()
        {
            ProcessOrderHandler poHandler = new ProcessOrderHandler(this);
            path = "http://localhost:55478/";
            //CreateProcessOrderCommand = new RelayCommand (poHandler.CreateProcessOrderAsync);
            ReadProcessOrderCommand = new RelayCommand(poHandler.ReadProcessOrder);
            DeleteProcessOrderCommand = new RelayCommand(poHandler.DeleteProcessOrder);
            EditProcessOrderCommand = new RelayCommand(poHandler.UpdateProcessOrder);

            //ProcessOrder = NewProcessOrder();
            processOrders.Add(new ProcessOrder(123, DateTime.Now, "Hejsa", true, 12,123456, 654321));

            //relaycommands
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
