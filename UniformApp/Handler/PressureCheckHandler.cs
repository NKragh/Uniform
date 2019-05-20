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

            var CreatePressurePersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<PressureCheck>("PressureCheck",
                CheckPageViewModel.NewPressureCheck);
        }

        public void ReadPressureCheck()
        {
            var ReadPressurePersistency = Persistency.PersistencyService
                .ReadObjectsFromDatabaseAsync<PressureCheck>("PerssureCheck",
                    CheckPageViewModel.ReadPressureCheckCommand).Result;
        }

        public void UpdatePressureCheck()
        {
            var UpdatePressurePersistency = Persistency.PersistencyService
                .UpdateObjectToDatabaseAsync<PressureCheck>("PressureCheck",
                    CheckPageViewModel.UpdatePressureCheckCommand).Result;
        }

        public void DeletePressureCheck()
        {
            var DeletePressurePersistency = Persistency.PersistencyService
                .DeleteObjectFromDatabaseAsync<PressureCheck>("PressureCheck",
                    CheckPageViewModel.DeletePressureCheckCommand).Result;
        }
    }
}
