namespace DesignPattern.Visitor
{
    public abstract class EmployeeBase
    {
        public abstract void Accept(VisitorBase visitor);
        public string Name { get; set; }
        public decimal Salary { get; set; }


    }
}
