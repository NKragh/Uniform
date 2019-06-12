using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Common;

namespace UniformApp.Model
{
    class LabelCheck : ICheckable
    {
        private int _processOrderNo;
        private TimeSpan _checkTime;
        private DateTimeOffset _expirationDate = DateTimeOffset.Now;
        private string _comment;
        private int _employeeNo;
        private int _labelNo;

        public int ProcessOrderNo { get => _processOrderNo; set => _processOrderNo = value; }
        public TimeSpan CheckTime { get => _checkTime; set => _checkTime = value; }
        public DateTimeOffset ExpirationDate { get => _expirationDate; set => _expirationDate = value.Date; }
        public string Comment { get => _comment; set => _comment = value; }
        public int EmployeeNo { get => _employeeNo; set => _employeeNo = value; }
        public int LabelNo { get => _labelNo; set => _labelNo = value; }

        public LabelCheck(int processOrderNo, TimeSpan checkTime, DateTime expirationDate, string comment, int employeeNo, int labelNo)
        {
            _processOrderNo = processOrderNo;
            _checkTime = checkTime;
            _expirationDate = expirationDate;
            _comment = comment;
            _employeeNo = employeeNo;
            _labelNo = labelNo;
        }

        public LabelCheck()
        {

        }
    }
}
