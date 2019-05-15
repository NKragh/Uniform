﻿using System;
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


        public WeightCheckHandler WeightCheckHandler { get; set; }

        public ICommand CreateWeightCheckCommand { get; set; }
        public ICommand ReadWeightCheckCommand { get; set; }
        public ICommand UpdateWeightCheckCommand { get; set; }
        public ICommand DeleteWeightCheckCommand { get; set; }

        private WeightCheck _newWeightCheck;

        public WeightCheck NewWeightCheck
        {
            get { return _newWeightCheck; }
            set { _newWeightCheck = value; }
        }


        public TasteCheckHandler TasteCheckHandler { get; set; }

        public ICommand CreateTasteCheckCommand { get; set; }
        public ICommand ReadTasteCheckCommand { get; set; }
        public ICommand UpdateTasteCheckCommand { get; set; }
        public ICommand DeleteTasteCheckCommand { get; set; }

        private TasteCheck _newTasteCheck;

        public TasteCheck NewTasteCheck
        {
            get { return _newTasteCheck; }
            set { _newTasteCheck = value; }
        }


        public CheckPageViewModel()
        {
            PressureCheckHandler = new PressureCheckHandler();
            CreatePressureCheckCommand = new RelayCommand(PressureCheckHandler.CreatePressureCheck);
            _newPressureCheck = new PressureCheck();

            WeightCheckHandler = new WeightCheckHandler();
            CreateWeightCheckCommand = new RelayCommand(WeightCheckHandler.CreateWeightCheck);
            _newWeightCheck = new WeightCheck();

            TasteCheckHandler = new TasteCheckHandler();
            CreateTasteCheckCommand = new RelayCommand(TasteCheckHandler.CreateTasteCheckHandler);
            _newTasteCheck = new TasteCheck();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}