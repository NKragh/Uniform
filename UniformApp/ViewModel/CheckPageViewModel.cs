using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        

        public bool Sample;
        private string _isChecked;

        public string IsChecked
        {
            get { return _isChecked; }
            set
            {
                if (value is "OK") Sample = true;
                else if (value is "Ikke OK") Sample = false;
                _isChecked = value;
            }
        }

        #region Properties

        public WeightCheckHandler WeightCheckHandler { get; set; }

        private WeightCheck _newWeightCheck;
        public WeightCheck NewWeightCheck
        {
            get { return _newWeightCheck; }
            set { _newWeightCheck = value; }
        }

        public TasteCheckHandler TasteCheckHandler { get; set; }

        private TasteCheck _newTasteCheck;
        public TasteCheck NewTasteCheck
        {
            get { return _newTasteCheck; }
            set { _newTasteCheck = value; }
        }

        public ShiftCheckHandler ShiftCheckHandler { get; set; }
        
        private ShiftCheck _newShiftCheck;
        public ShiftCheck NewShiftCheck
        {
            get { return _newShiftCheck; }
            set { _newShiftCheck = value; }
        }

        public LabelCheckHandler LabelCheckHandler { get; set; }
        
        private LabelCheck _newLabelCheck;
        public LabelCheck NewLabelCheck
        {
            get { return _newLabelCheck; }
            set { _newLabelCheck = value; }
        }

        public PressureCheckHandler PressureCheckHandler { get; set; }
        
        private PressureCheck _newPressureCheck;
        public PressureCheck NewPressureCheck
        {
            get { return _newPressureCheck; }
            set { _newPressureCheck = value; }
        }
        public SampleCheckHandler SampleCheckHandler { get; set; }

        private SampleCheck _newSampleCheck;
        public SampleCheck NewSampleCheck
        {
            get { return _newSampleCheck; }
            set { _newSampleCheck = value; }
        }

        public TorqueCheckHandler TorqueCheckHandler { get; set; }
        private TorqueCheck _newTorqueCheck;

        public TorqueCheck NewTorqueCheck
        {
            get => _newTorqueCheck;
            set => _newTorqueCheck = value;
        }

        public PETCheckHandler PETCheckHandler { get; set; }
        private PETCheck _newPETCheck;
        public PETCheck NewPETCheck
        {
            get => _newPETCheck;
            set => _newPETCheck = value;
        }

        #endregion

        public ICommand CreateCommand { get; set; }
        public ICommand ReadCommand { get; set; }
        public ICommand ChangeCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public ProcessOrderCatalog ProcessOrderCatalog { get; set; }
        public EmployeeCatalog EmployeeCatalog { get; set; }
        public ProductCatalog ProductCatalog{ get; set; }

        public ObservableCollection<bool> BooleanArray { get; set; }


        public CheckPageViewModel()
        {
            ProcessOrderCatalog = ProcessOrderCatalog.Instance;
            EmployeeCatalog = EmployeeCatalog.Instance;
            ProductCatalog = ProductCatalog.Instance;
            BooleanArray = new ObservableCollection<bool>() {true, false};

            WeightCheckHandler = new WeightCheckHandler(this);
            TasteCheckHandler = new TasteCheckHandler(this);
            ShiftCheckHandler = new ShiftCheckHandler(this);
            LabelCheckHandler = new LabelCheckHandler(this);
            PressureCheckHandler = new PressureCheckHandler(this);
            SampleCheckHandler = new SampleCheckHandler(this);
            TorqueCheckHandler = new TorqueCheckHandler(this);
            PETCheckHandler = new PETCheckHandler(this);

            _newWeightCheck = new WeightCheck();
            _newTasteCheck = new TasteCheck();
            _newShiftCheck = new ShiftCheck();
            _newLabelCheck = new LabelCheck();
            _newPressureCheck = new PressureCheck();
            _newSampleCheck = new SampleCheck();
            _newTorqueCheck = new TorqueCheck();
            _newPETCheck = new PETCheck();

            ChangeCommand = new URelayCommand(ChooseCommand);
        }

        public void ChooseCommand(object parameter)
        {
            switch (parameter)
            {
                case "WeightCheck":
                    CreateCommand = new RelayCommand(WeightCheckHandler.CreateWeightCheck);
                    break;
                case "TasteCheck":
                    CreateCommand = new RelayCommand(TasteCheckHandler.CreateTasteCheck);
                    break;
                case "LabelCheck":
                    CreateCommand = new RelayCommand(LabelCheckHandler.CreateLabelCheck);
                    break;
                case "SampleCheck":
                    CreateCommand = new RelayCommand(SampleCheckHandler.CreateSampleCheck);
                    break;
                case "ShiftCheck":
                    CreateCommand = new RelayCommand(ShiftCheckHandler.CreateShiftCheck);
                    break;
                case "TorqueCheck":
                    CreateCommand = new RelayCommand(TorqueCheckHandler.CreateTorqueCheck);
                    break;
                case "PressureCheck":
                    CreateCommand = new RelayCommand(PressureCheckHandler.CreatePressureCheck);
                    break;
                case "PETCheck":
                    CreateCommand = new RelayCommand(PETCheckHandler.CreatePETCheck);
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
