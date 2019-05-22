﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Composition.Interactions;
using GalaSoft.MvvmLight.Command;
using UniformApp.Annotations;
using UniformApp.Common;
using UniformApp.Handler;
using UniformApp.Model;
using UniformApp.View;

namespace UniformApp.ViewModel
{
    class CheckPageViewModel : INotifyPropertyChanged
    {
        //TODO Clean
        #region Temp

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

        public LabelCheckHandler LabelCheckHandler { get; set; }

        public ICommand CreateLabelCheckCommand { get; set; }
        public ICommand ReadLabelCheckCommand { get; set; }
        public ICommand UpdateLabelCheckCommand { get; set; }
        public ICommand DeleteLabelCheckCommand { get; set; }

        private LabelCheck _newLabelCheck;

        public LabelCheck NewLabelCheck
        {
            get { return _newLabelCheck; }
            set { _newLabelCheck = value; }
        }


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

        #endregion

        public ICommand CreateCommand { get; set; }
        public ICommand ReadCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public CheckPageViewModel()
        {
            WeightCheckHandler = new WeightCheckHandler(this);
            CreateWeightCheckCommand = new RelayCommand(WeightCheckHandler.CreateWeightCheck);
            _newWeightCheck = new WeightCheck();

            TasteCheckHandler = new TasteCheckHandler();
            CreateTasteCheckCommand = new RelayCommand(TasteCheckHandler.CreateTasteCheckHandler);
            _newTasteCheck = new TasteCheck();

            ShiftCheckHandler = new ShiftCheckHandler(this);

            CreateShiftCheckCommand = new RelayCommand(ShiftCheckHandler.CreateShiftCheck);
            ReadShiftCheckCommand = new RelayCommand(ShiftCheckHandler.ReadShiftCheck);
            UpdateShiftCheckCommand = new RelayCommand(ShiftCheckHandler.UpdateShiftCheck);
            DeleteShiftCheckCommand = new RelayCommand(ShiftCheckHandler.DeleteShiftCheck);

            _newShiftCheck = new ShiftCheck();
            LabelCheckHandler = new LabelCheckHandler();
            CreateLabelCheckCommand = new RelayCommand(LabelCheckHandler.CreateLabelCheck);
            _newLabelCheck = new LabelCheck();

            PressureCheckHandler = new PressureCheckHandler(this);
            CreatePressureCheckCommand = new RelayCommand(PressureCheckHandler.CreatePressureCheck);
            _newPressureCheck = new PressureCheck();

            UpdateCommand = new URelayCommand(ChangeCommand);
        }

        public void ChangeCommand(object parameter)
        {
            switch (parameter)
            {
                //TODO: Den går herind to gange for some reason...
                case "WeightCheck":
                    CreateCommand = new RelayCommand(WeightCheckHandler.CreateWeightCheck);
                    break;
                case "TasteCheck":
                    CreateCommand = new RelayCommand(TasteCheckHandler.CreateTasteCheckHandler);
                    break;
                case "LabelCheck":
                    CreateCommand = new RelayCommand(LabelCheckHandler.CreateLabelCheck);
                    break;
                case "SampleCheck":
                    //CreateCommand = new RelayCommand();
                    break;
                case "ShiftCheck":
                    //CreateCommand = new RelayCommand();
                    break;
                case "TorqueCheck":
                    //CreateCommand = new RelayCommand();
                    break;
                case "PressureCheck":
                    CreateCommand = new RelayCommand(PressureCheckHandler.CreatePressureCheck);
                    break;
                case "PETCheck":
                    //CreateCommand = new RelayCommand();
                    break;
                default:
                    throw new NullReferenceException();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
