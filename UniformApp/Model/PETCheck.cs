using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Common;

namespace UniformApp.Model
{
    class PETCheck : ICheckable
    {
        private int _processOrderNo;
        private TimeSpan _checkTime;
        private int _formNo;
        private float _bottomValue;
        private float _midValue;
        private float _topValue;
        private string _comment;
        private int _employeeNo;
        private int _preformNo;

        public int ProcessOrderNo { get => _processOrderNo; set => _processOrderNo = value; }
        public TimeSpan CheckTime { get => _checkTime; set => _checkTime = value; }
        public int FormNo { get => _formNo; set => _formNo = value; }
        public float BottomValue { get => _bottomValue; set => _bottomValue = value; }
        public float MidValue { get => _midValue; set => _midValue = value; }
        public float TopValue { get => _topValue; set => _topValue = value; }
        public string Comment { get => _comment; set => _comment = value; }
        public int EmployeeNo { get => _employeeNo; set => _employeeNo = value; }
        public int PreformNo { get => _preformNo; set => _preformNo = value; }

        public PETCheck(int processOrderNo, TimeSpan checkTime, int formNo, float bottomValue, float midValue, float topValue, string comment, int employeeNo, int preformNo)
        {
            _processOrderNo = processOrderNo;
            _checkTime = checkTime;
            _formNo = formNo;
            _bottomValue = bottomValue;
            _midValue = midValue;
            _topValue = topValue;
            _comment = comment;
            _employeeNo = employeeNo;
            _preformNo = preformNo;
        }

        public PETCheck()
        {
        }
    }
}
