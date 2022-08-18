namespace DesignPattern.Prototype
{
    public class Employee : Person
    {
        public override Person Clone()
        {
           return(Person)MemberwiseClone();
        }
        public decimal Salary { get; set; }
    }
}
