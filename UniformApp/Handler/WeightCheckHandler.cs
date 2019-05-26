using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Model;
using UniformApp.View;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class WeightCheckHandler
    {
        public CheckPageViewModel CheckPageViewModel { get; set; }

        public WeightCheckHandler(CheckPageViewModel viewModel)
        {
            CheckPageViewModel = viewModel;
        }

        public void CreateWeightCheck()
        {
            CheckPageViewModel.NewWeightCheck.ProcessOrderNo = ProcessOrderCatalog.Instance.TargetProcessOrder.ProcessOrderNo;
            CheckPageViewModel.NewWeightCheck.EmployeeNo = EmployeeCatalog.Instance.TargetEmployee.EmployeeNo;
            CheckPageViewModel.NewWeightCheck.CheckTime = DateTime.Now.TimeOfDay;
            CheckPageViewModel.NewWeightCheck.ProductNo = ProcessOrderCatalog.Instance.TargetProcessOrder.ProductNo;
            CheckPageViewModel.NewWeightCheck.Droptest = CheckPageViewModel.Sample;
            
            var weightPersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<WeightCheck>("WeightCheck", CheckPageViewModel.NewWeightCheck).Result;
        }
    }
}
