namespace DesignPattern.Visitor
{
    public class Managers : EmployeeBase
    {
        public List<EmployeeBase> Subordinates { get; set; }

        public Managers()
        {
            Subordinates = new List<EmployeeBase>();
        }

        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
            foreach (var employee in Subordinates)
            {
                employee.Accept(visitor);
            }
        }



    }
}
