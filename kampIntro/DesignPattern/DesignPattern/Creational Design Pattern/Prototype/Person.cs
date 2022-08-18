using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    public abstract  class Person
    {
        public abstract Person Clone();
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
