using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public abstract class CourseMember
    {
        protected Mediator _mediator;

        public CourseMember(Mediator mediator)
        {
            _mediator = mediator;
        }
    }
}
