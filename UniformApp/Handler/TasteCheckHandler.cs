using System;
using UniformApp.Model;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class TasteCheckHandler
    {
        public CheckPageViewModel CheckPageViewModel { get; set; }

        public TasteCheckHandler(CheckPageViewModel viewModel)
        {
            CheckPageViewModel = viewModel;
        }
        public void CreateTasteCheck()
        {
            CheckPageViewModel.NewTasteCheck.ProcessOrderNo = ProcessOrderCatalog.Instance.TargetProcessOrder.ProcessOrderNo;
            CheckPageViewModel.NewTasteCheck.EmployeeNo = EmployeeCatalog.Instance.TargetEmployee.EmployeeNo;
            CheckPageViewModel.NewTasteCheck.CheckTime = DateTime.Now.TimeOfDay;

            var tastePersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<TasteCheck>("TasteCheck", CheckPageViewModel.NewTasteCheck).Result;
        }
    }
}
