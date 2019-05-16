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
    class CheckPageViewModel : INotifyPropertyChanged
    {
        public PressureCheckHandler PressureCheckHandler { get; set; }

        public ICommand CreatePressureCheckCommand { get; set; }
        public ICommand ReadPressureCheckCommand { get; set; }
        public ICommand UpdatePressureCheckCommand { get; set; }
        public ICommand DeletePressureCheckCommand { get; set; }

        private PressureCheck _newPressureCheck;

        public PressureCheck NewPressureCheck
        {
            get { return _newPressureCheck; }
            set { _newPressureCheck = value; }
        }

        /// <summary>
        /// Adding relay command and binding PHandler with ViewModel. 
        /// </summary>
        public CheckPageViewModel()
        {
            PressureCheckHandler = new PressureCheckHandler(this);

            CreatePressureCheckCommand = new RelayCommand(PressureCheckHandler.CreatePressureCheck);

            _newPressureCheck = new PressureCheck();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //Notifies clients that a property value has changed.
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
