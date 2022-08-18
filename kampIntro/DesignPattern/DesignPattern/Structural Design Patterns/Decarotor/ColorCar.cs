namespace DesignPattern.Decarotor
{
    public class ColorCar : CarBase
    {
        private readonly CarBase _carBase;
        public string color = "red";

        public ColorCar(CarBase carBase)
        {
            _carBase = carBase;
        }

        public override string Brand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Model {
            get 
            {
                return color+ " "+ _carBase.Model;
            } 
            set 
            { 

            }
        }
        public override decimal HirePrice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
