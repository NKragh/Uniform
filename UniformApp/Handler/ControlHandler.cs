using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Model;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class ControlHandler
    {
        public CheckPageViewModel CheckPageViewModel { get; set; }

        private CompleteCheckView _targetCompleteCheckView;

        public CompleteCheckView TargetCompleteCheckView
        {
            get { return _targetCompleteCheckView; }
            set { _targetCompleteCheckView = value; }
        }

        public ControlHandler(CheckPageViewModel viewModel)
        {
            CheckPageViewModel = viewModel;
        }

        public async void LoadCompleteCheckViewsAsync()
        {
            var checks = await Persistency.PersistencyService.ReadObjectsFromDatabaseAsync<CompleteCheckView>("CompleteCheckView");

            if (checks.Count != 0)
            {
                foreach (var c in checks)
                {
                    if (c.ProcessOrderNo == ProcessOrderCatalog.Instance.TargetProcessOrder.ProcessOrderNo)
                    {
                        TargetCompleteCheckView = c;
                    }
                }
            }
            else
            {
                TargetCompleteCheckView = new CompleteCheckView("defaultProduct2", 123, 456, 789, 123456789, "defaultBatch2", 098, 765);
            }
        }

    }
}
