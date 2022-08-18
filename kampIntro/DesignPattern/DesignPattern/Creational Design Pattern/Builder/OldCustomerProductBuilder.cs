namespace DesignPattern.Builder
{
    public class OldCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();
        public override void ApplyDiscount()
        {
            model.Discount = model.UnitPrice * (decimal)0.60;
            model.DiscountApplied = true;
        }

        public override void GetProductData()
        {
            model.Id = 1;
            model.CategoryName = "Beverages";
            model.ProductName = "Chai";
            model.UnitPrice = 20;
        }

        public override ProductViewModel GetProductViewModel()
        {
            return model;
        }
    }
}
