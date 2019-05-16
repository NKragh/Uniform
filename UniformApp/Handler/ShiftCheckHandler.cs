using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class ShiftCheckHandler
    {
        public ShiftCheckViewModel ShiftCheckViewModel { get; set; }

        public ShiftCheckHandler(ShiftCheckViewModel viewModel)
        {
            ShiftCheckViewModel = viewModel;
        }

        // <summary>
        // Default C-R-U-D features for application
        // </summary>

        public void CreateShiftCheck()
        {
            throw new NotImplementedException();
        }

        public void ReadShiftCheck()
        {
            throw new NotImplementedException();
        }

        public void UpdateShiftCheck()
        {
            throw new NotImplementedException();
        }

        public void DeleteShiftCheck()
        {
            throw new NotImplementedException();
        }
    }
}
