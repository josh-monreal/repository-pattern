﻿using RP.Domain;
using System.Collections.Generic;

namespace RP.Data.Core
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Employee> GetTop5Employees();
    }
}
