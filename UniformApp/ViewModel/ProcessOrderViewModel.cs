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
using UniformApp.View;

namespace UniformApp.ViewModel
{
    class ProcessOrderViewModel : INotifyPropertyChanged
    {
        public ProcessOrderCatalog ProcessOrderCatalog { get; set; }
        public ProcessOrderHandler ProcessOrderHandler { get; set; }

        public ICommand CreateProcessOrderCommand { get; set; }
        public ICommand DeleteProcessOrderCommand { get; set; }
        public ICommand EditProcessOrderCommand { get; set; }

        private ProcessOrder _newProcessOrder;

        public ProcessOrder NewProcessOrder
        {
            get { return _newProcessOrder; }
            set
            {
                _newProcessOrder = value;
            }
        }

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
            ProcessOrderCatalog = ProcessOrderCatalog.Instance;
            ProcessOrderHandler = new ProcessOrderHandler(this);

            CreateProcessOrderCommand =new RelayCommand(ProcessOrderHandler.CreateProcessOrder);

            _newProcessOrder = new ProcessOrder();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
