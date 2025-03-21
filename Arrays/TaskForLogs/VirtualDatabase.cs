using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForLogs
{
    public static class VirtualDatabase
    {
        public static int EmplayeeIdentity = 1;
        public static BindingList<Employee> Employess { get; set; } = new BindingList<Employee>();        
    }
}
