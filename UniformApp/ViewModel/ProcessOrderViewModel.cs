using System;
using System.Collections.Generic;
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
        public EmployeeCatalog PreformCatalog { get; set; }
        public ProductCatalog ProductCatalog { get; set; }
        public ProcessOrderCatalog ProcessOrderCatalog { get; set; }
        public ProcessOrderHandler ProcessOrderHandler { get; set; }
       
        public ICommand CreateProcessOrderCommand { get; set; }
        public ICommand DeleteProcessOrderCommand { get; set; }
        public ICommand EditProcessOrderCommand { get; set; }
        public ICommand ReadProcessOrderCommand { get; set; }

        private ProcessOrder _newProcessOrder;
        public ProcessOrder NewProcessOrder
        {
            get { return _newProcessOrder; }
            set
            {
                _newProcessOrder = value;
            }
        }

        public ProcessOrderViewModel()
        {
            PreformCatalog = EmployeeCatalog.Instance;
            ProductCatalog = ProductCatalog.Instance;
            ProcessOrderCatalog = ProcessOrderCatalog.Instance;
            ProcessOrderHandler = new ProcessOrderHandler(this);

            CreateProcessOrderCommand = new RelayCommand(ProcessOrderHandler.CreateProcessOrder);

            _newProcessOrder = new ProcessOrder();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
