using CQRS_Demo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Demo.Repositories
{
    public class EmployeeQueriesRepository : IEmployeeQueriesRepository
    {
        public Employee GetByID(int employeeID)
        {
            return new Employee()
            {
                Id = 100,
                FirstName = "John",
                LastName = "Smith",
                DateOfBirth = new DateTime(2000, 1, 1),
                Street = "100 Toronto Street",
                City = "Toronto",
                PostalCode = "k1k 1k1"
            };
        }
    }
}
