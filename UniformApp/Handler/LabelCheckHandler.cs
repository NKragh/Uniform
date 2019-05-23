using System;
using UniformApp.Model;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class LabelCheckHandler
    {
        public CheckPageViewModel CheckPageViewModel { get; set; }

        public LabelCheckHandler(CheckPageViewModel viewModel)
        {
            CheckPageViewModel = viewModel;
        }
        public void CreateLabelCheck()
        {
            CheckPageViewModel.NewLabelCheck.ProcessOrderNo = ProcessOrderCatalog.Instance.TargetProcessOrder.ProcessOrderNo;
            CheckPageViewModel.NewLabelCheck.EmployeeNo = EmployeeCatalog.Instance.TargetEmployee.EmployeeNo;
            CheckPageViewModel.NewLabelCheck.CheckTime = DateTime.Now.TimeOfDay;

            var labelPersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<LabelCheck>("LabelCheck", CheckPageViewModel.NewLabelCheck).Result;
        }
    }
}
