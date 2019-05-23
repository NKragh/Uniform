using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Common
{
    interface ICheckable
    {
        int ProcessOrderNo { get; set; }
        TimeSpan CheckTime { get; set; }
    }
}
