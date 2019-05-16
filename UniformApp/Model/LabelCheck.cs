using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class LabelCheck
    {
        private int _processOrderNo;
        private DateTime _checkTime;
        private DateTime _expirationDate;
        private string _comment;
        private int _employeeNo;
        private int _labelNo;

        public int ProcessOrderNo { get => _processOrderNo; set => _processOrderNo = value; }
        public DateTime CheckTime { get => _checkTime; set => _checkTime = value; }
        public DateTime ExpirationDate { get => _expirationDate; set => _expirationDate = value; }
        public string Comment { get => _comment; set => _comment = value; }
        public int EmployeeNo { get => _employeeNo; set => _employeeNo = value; }
        public int LabelNo { get => _labelNo; set => _labelNo = value; }

        public LabelCheck(int processOrderNo, DateTime checkTime, DateTime expirationDate, string comment, int employeeNo, int labelNo)
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
