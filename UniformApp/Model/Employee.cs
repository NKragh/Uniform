using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class Employee
    {
        private int _employeeNo;
        [StringLength(4)]
        private string _initials;
        private byte _level;

        public int EmployeeNo { get => _employeeNo; set => _employeeNo = value; }
        public string Initials { get => _initials; set => _initials = value; }
        public byte Level { get => _level; set => _level = value; }

        public Employee(int employeeNo, string initials, byte level)
        {
            EmployeeNo = employeeNo;
            Initials = initials;
            Level = level;
        }

        public Employee()
        {
            
        }
    }
}
