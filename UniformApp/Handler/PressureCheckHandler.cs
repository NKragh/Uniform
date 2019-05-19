using System;
using System.Diagnostics;
using UniformApp.Model;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class PressureCheckHandler
    {
        //Binding with Handler with ViewModel
        public CheckPageViewModel CheckPageViewModel { get; set; }

        public PressureCheckHandler(CheckPageViewModel viewModel)
        {
            CheckPageViewModel = viewModel;
        }

        public PressureCheckHandler()
        {
        }

        /// <summary>
        /// Default C-R-U-D features for application 
        /// </summary>
        public void CreatePressureCheck()
        {
            CheckPageViewModel.NewPressureCheck.EmployeeNo = ProcessOrderCatalog.Instance.TargetProcessOrder.EmployeeNo;
            CheckPageViewModel.NewPressureCheck.ProcessOrderNo = ProcessOrderCatalog.Instance.TargetProcessOrder.ProcessOrderNo;
            CheckPageViewModel.NewPressureCheck.CheckTime = DateTime.Now.TimeOfDay; //TODO Johan/Ncraigh help

            var PressurePersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<PressureCheck>("PressureCheck",
                CheckPageViewModel.NewPressureCheck);
        }

        public void ReadPressureCheck()
        {
            throw new NotImplementedException();
        }

        public void UpdatePressureCheck()
        {
            throw new NotImplementedException();
        }

        public void DeletePressureCheck()
        {
            throw new NotImplementedException();
        }
    }
}
