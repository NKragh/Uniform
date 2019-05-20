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
        private int _processOrderNo;
        private TimeSpan _checkTime;
        private bool _topLabel;
        private bool _tapPipe;
        private bool _suger;
        private int _palletNo;
        private int _employeeNo; 


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
            bool sugar, int palletNo, int employeeNo)
        {
            ProcessOrderNo = processOrderNo;
            CheckTime = checkTime;
            TopLabel = topLabel;
            TapPipe = tapPipe;
            Sugar = sugar;
            PalletNo = palletNo;
            EmployeeNo = employeeNo;
        }

        public ShiftCheck()
        {
            
        }
    }
}
