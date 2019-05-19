using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Model;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class TorqueCheckHandler
    {
        public CheckPageViewModel CheckPageViewModel { get; set; }

        public TorqueCheckHandler(CheckPageViewModel viewModel)
        {
            CheckPageViewModel = viewModel;
        }

        public TorqueCheckHandler()
        {
        }

        public void CreateTorqueCheck()
        {

        }
        public void ReadTorqueCheck()
        {

        }
        public void UpdateTorqueCheck()
        {

        }
        public void DeleteTorqueCheck()
        {

        }
    }
}
