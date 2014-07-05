using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain;

namespace Service.Employee
{
    public class EmployeeService : IEmployeeService
    {
        public List<EmployeeDto> GetEmployees()
        {
            //throw new ApplicationException("Something really bad just happened!");

            return new List<EmployeeDto>
            {
                new EmployeeDto() { Id = Guid.NewGuid(), Age = 22, FirstName = "Christopher", Surname = "Auret", Mobile = "0416380246"},
                new EmployeeDto() { Id = Guid.NewGuid(), Age = 27, FirstName = "Daniel", Surname = "Pearson", Mobile = "0416992422"},
                new EmployeeDto() { Id = Guid.NewGuid(), Age = 25, FirstName = "Lexie", Surname = "Lewis", Mobile = "0414570246"},
                new EmployeeDto() { Id = Guid.NewGuid(), Age = 34, FirstName = "Rebecca", Surname = "McMahon", Mobile = "0489320246"}
            };
        }
    }
}

// Break all processes when one process breaks.
// Enable just my code.