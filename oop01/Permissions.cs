using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop01
{
    [Flags]
    internal enum Permissions
    {
        Read = 1 , 
        write = 2 , 
        Delete = 4 , 
        Execute = 8 
    }
}
