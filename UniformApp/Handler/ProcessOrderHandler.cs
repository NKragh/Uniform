using UniformApp.Model;
using UniformApp.View;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class ProcessOrderHandler
    {
        public ProcessOrderViewModel ProcessOrderViewModel { get; set; }
        
        public ProcessOrderHandler(ProcessOrderViewModel viewModel)
        {
            ProcessOrderViewModel = viewModel;
        }

        public void CreateProcessOrder()
        {
            ProcessOrderViewModel.NewProcessOrder.ColumnNo = ProcessOrderPage.ColumnChoice;
            ProcessOrderViewModel.NewProcessOrder.EmployeeNo = EmployeeCatalog.Instance.TargetEmployee.EmployeeNo;
            ProcessOrderViewModel.NewProcessOrder.ProductNo = ProductCatalog.Instance.TargetProduct.ProductNo;

            var processOrderPersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<ProcessOrder>("ProcessOrder", ProcessOrderViewModel.NewProcessOrder).Result;
            if (processOrderPersistency)
            {
                ProcessOrderCatalog.Instance.ProcessOrderList.Add(ProcessOrderViewModel.NewProcessOrder);
            }
        }
    }
}