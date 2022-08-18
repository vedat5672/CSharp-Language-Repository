namespace DesignPattern.Visitor
{
    public class PayrollVisitor : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} paid {1}", worker.Name, worker.Salary);
        }

        public override void Visit(Managers manager)
        {
            Console.WriteLine("{0} paid {1}", manager.Name, manager.Salary); ;
        }
    }
}
