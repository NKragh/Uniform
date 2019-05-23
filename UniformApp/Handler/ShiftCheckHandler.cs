using System;
using UniformApp.Model;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class ShiftCheckHandler
    {
        public CheckPageViewModel CheckPageViewModel { get; set; }

        public ShiftCheckHandler(CheckPageViewModel viewModel)
        {
            CheckPageViewModel = viewModel;
        }

        public void CreateShiftCheck()
        {
            CheckPageViewModel.NewShiftCheck.ProcessOrderNo = ProcessOrderCatalog.Instance.TargetProcessOrder.ProcessOrderNo;
            CheckPageViewModel.NewShiftCheck.EmployeeNo = EmployeeCatalog.Instance.TargetEmployee.EmployeeNo;
            CheckPageViewModel.NewShiftCheck.CheckTime = DateTime.Now.TimeOfDay;

            var shiftPersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<ShiftCheck>("ShiftCheck", CheckPageViewModel.NewShiftCheck).Result;
        }
    }
}
