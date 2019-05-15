using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Common
{
    interface ICheckable
    {
        int ProcessNo { get; set; }
        DateTime CheckTime { get; }
    }
}
