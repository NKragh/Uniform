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
    class ShiftCheckViewModel : INotifyPropertyChanged
    {

        public ShiftCheckHandler ShiftCheckHandler { get; set; }

        public ICommand CreateShiftCheckCommand { get; set; }
        public ICommand ReadShiftCheckCommand { get; set; }
        public ICommand UpdateShiftCheckCommand { get; set; }
        public ICommand DeleteShiftCheckCommand { get; set; }

        private ShiftCheck _newShiftCheck;

        public ShiftCheck NewShiftCheck
        {
            get { return _newShiftCheck; }
            set { _newShiftCheck = value; }
        }

        public ShiftCheckViewModel()
        {
            ShiftCheckHandler = new ShiftCheckHandler(this);

            CreateShiftCheckCommand = new RelayCommand(ShiftCheckHandler.CreateShiftCheck);
            ReadShiftCheckCommand = new RelayCommand(ShiftCheckHandler.ReadShiftCheck);
            UpdateShiftCheckCommand = new RelayCommand(ShiftCheckHandler.UpdateShiftCheck);
            DeleteShiftCheckCommand = new RelayCommand(ShiftCheckHandler.DeleteShiftCheck);

            _newShiftCheck = new ShiftCheck();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
