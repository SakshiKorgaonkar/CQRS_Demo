using CQRS_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Demo.Commands
{
    public interface IEmployeeCommands
    {
        void SaveEmployeeData(Employee employee);

    }
}
