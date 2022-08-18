using DesignPattern.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
    public class OrganisationalStructure
    {
        public EmployeeBase _employee;

        public OrganisationalStructure(EmployeeBase firstEmployee)
        {
            _employee = firstEmployee;
        }
        public void Accept(VisitorBase visitor)
        {
            _employee.Accept(visitor);
        }
    }
}
