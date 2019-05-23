using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Common;

namespace UniformApp.Model
{
    class ShiftCheck : ICheckable
    {
        private int _processOrderNo;
        private TimeSpan _checkTime;
        private bool _topLabel;
        private bool _tapPipe;
        private bool _sugar;
        private int _palletNo;
        private int _employeeNo;

        public int ProcessOrderNo { get => _processOrderNo; set => _processOrderNo = value; }
        public TimeSpan CheckTime { get => _checkTime; set => _checkTime = value; }
        public bool TopLabel { get => _topLabel; set => _topLabel = Boolean.Parse(value.ToString()); }
        public bool TapPipe { get => _tapPipe; set => _tapPipe = Boolean.Parse(value.ToString()); }
        public bool Sugar { get => _sugar; set => _sugar = Boolean.Parse(value.ToString()); }
        public int PalletNo { get => _palletNo; set => _palletNo = value; }
        public int EmployeeNo { get => _employeeNo; set => _employeeNo = value; }

        public ShiftCheck(int processOrderNo, TimeSpan checkTime, string topLabel, string tapPipe, string sugar, int palletNo, int employeeNo)
        {
            _processOrderNo = processOrderNo;
            _checkTime = checkTime;
            _topLabel = Boolean.Parse(topLabel);
            _tapPipe = Boolean.Parse(tapPipe);
            _sugar = Boolean.Parse(sugar);
            _palletNo = palletNo;
            _employeeNo = employeeNo;
        }

        public ShiftCheck()
        {
        }
    }
}
