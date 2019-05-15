using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Common;

namespace UniformApp.Model
{
    class tempCheck : ICheckable
    {
        //model klasser skal implementere ICheckable som properties med backing field - det er del af options hvis du implementer vha. ReSharper Ultimate (alt+enter)
        private int _processNo;
        private DateTime _checkTime;

        public int ProcessNo
        {
            get => _processNo;
            set => _processNo = value;
        }

        public DateTime CheckTime
        {
            get => _checkTime;
            set => _checkTime = DateTime.Now;
        }
    }
}
