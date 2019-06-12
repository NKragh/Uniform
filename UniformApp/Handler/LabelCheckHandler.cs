using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UniformApp.Annotations;
using UniformApp.Model;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class LabelCheckHandler : INotifyPropertyChanged
    {
        private bool _labelPersistency;
        public CheckPageViewModel CheckPageViewModel { get; set; }

        public bool LabelPersistency
        {
            get => _labelPersistency;
            set
            {
                _labelPersistency = value; 
                OnPropertyChanged();
            }
        }

        public LabelCheckHandler(CheckPageViewModel viewModel)
        {
            CheckPageViewModel = viewModel;
        }
        public void CreateLabelCheck()
        {
            CheckPageViewModel.NewLabelCheck.ProcessOrderNo = ProcessOrderCatalog.Instance.TargetProcessOrder.ProcessOrderNo;
            CheckPageViewModel.NewLabelCheck.EmployeeNo = EmployeeCatalog.Instance.TargetEmployee.EmployeeNo;
            CheckPageViewModel.NewLabelCheck.CheckTime = DateTime.Now.TimeOfDay;
            CheckPageViewModel.NewLabelCheck.LabelNo = LabelCatalog.Instance.TargetLabel.LabelNo;

            LabelPersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<LabelCheck>("LabelCheck", CheckPageViewModel.NewLabelCheck).Result;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
