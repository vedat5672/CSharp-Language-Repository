namespace DesignPattern.Prototype
{
    public class Customer : Person
    {
        public override Person Clone()
        {
           return(Person)MemberwiseClone();
        }
        public string City { get; set; }
    } 
}
