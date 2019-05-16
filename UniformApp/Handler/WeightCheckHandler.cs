using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Model;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class WeightCheckHandler
    {
        /// <summary>
        /// 
        /// </summary>

        public CheckPageViewModel CheckPageViewModel { get; set; }

        public WeightCheckHandler(CheckPageViewModel viewModel)
        {
            CheckPageViewModel = viewModel;
        }
        public void CreateWeightCheck()
        {
            CheckPageViewModel.NewWeightCheck.EmployeeNo = ProcessOrderCatalog.Instance.TargetProcessOrder.EmployeeNo;
            CheckPageViewModel.NewWeightCheck.ProductNo = ProcessOrderCatalog.Instance.TargetProcessOrder.ProductNo;
            CheckPageViewModel.NewWeightCheck.ProcessOrderNo =
                ProcessOrderCatalog.Instance.TargetProcessOrder.ProcessOrderNo;
            var weightPersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<WeightCheck>("WeightCheck", CheckPageViewModel.NewWeightCheck).Result;
        }

        public void ReadWeightCheck()
        {
            throw new NotImplementedException();
        }
    }
}
