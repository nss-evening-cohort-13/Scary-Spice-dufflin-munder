using System;
using System.Collections.Generic;
using System.Text;
using ScarySpiceDufflinMunder.Employees;

namespace ScarySpiceDufflinMunder.Employees.Employee
{
       /********
        ******** Accountant
        ******** Description: Accountant is a derived class of the base class called EmployeeBase.
        ******** Arguments: string name
        ********/
    public class Accountant : EmployeeBase
    {
        // constructor
        public Accountant(string name)
        {
            Name = name;
        }

    }
}
