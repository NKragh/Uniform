using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Model;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class SampleCheckHandler
    {
        public CheckPageViewModel CheckPageViewModel { get; set; }

        public SampleCheckHandler(CheckPageViewModel viewModel)
        {
            CheckPageViewModel = viewModel;
        }

        public void CreateSampleCheck()
        {
            CheckPageViewModel.NewSampleCheck.ProcessOrderNo = ProcessOrderCatalog.Instance.TargetProcessOrder.ProcessOrderNo;
            CheckPageViewModel.NewSampleCheck.EmployeeNo = EmployeeCatalog.Instance.TargetEmployee.EmployeeNo;
            CheckPageViewModel.NewSampleCheck.CheckTime = DateTime.Now.TimeOfDay;
            CheckPageViewModel.NewSampleCheck.Sample = CheckPageViewModel.Sample;

            var samplePersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<SampleCheck>("SampleCheck", CheckPageViewModel.NewSampleCheck).Result;
        }
    }
}
