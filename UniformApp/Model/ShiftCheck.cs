using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class ShiftCheck
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="processOrderNo">Processorder number from Processorder</param>
        /// <param name="toplabel"></param>
        /// <param name="tapPipe"></param>
        /// <param name="sugar"></param>
        /// <param name="palletNo"></param>
        /// <param name="employeeNo">Employee number from Employee</param>
        private int _processOrderNo { get; set; }
        private TimeSpan _checkTime { get; set; }
        private bool _topLabel { get; set; }
        private bool _tapPipe { get; set; }
        private bool _suger { get; set; }
        private int _palletNo { get; set; }
        private int _employeeNo { get; set; }


        public  int ProcessOrderNo
        {
            get => _processOrderNo;
            set => _processOrderNo = value;
        }

        public TimeSpan CheckTime{ get => _checkTime; set => _checkTime  = value; }

        public bool TopLabel
        {
            get => _topLabel; set => _topLabel = value;
        }
        
        public bool TapPipe
        {
            get => _tapPipe;
            set => _tapPipe = value;
        }

        public bool Sugar
        {
            get => _suger;
            set => _suger = value;
        }

        public int PalletNo
        {
            get => _palletNo;
            set => _palletNo = value;
        }

        public int EmployeeNo
        {
            get => _employeeNo;
            set => _employeeNo = value;
        }

        public ShiftCheck(int processOrderNo, TimeSpan checkTime, bool topLabel, bool tapPipe,
            bool sugar, int palletNo, int emplyeeNo)
        {
            ProcessOrderNo = processOrderNo;
            CheckTime = checkTime;
            TopLabel = topLabel;
            TapPipe = tapPipe;
            Sugar = sugar;
            PalletNo = palletNo;
            EmployeeNo = emplyeeNo;
        }

        public ShiftCheck()
        {
            
        }
    }
}
