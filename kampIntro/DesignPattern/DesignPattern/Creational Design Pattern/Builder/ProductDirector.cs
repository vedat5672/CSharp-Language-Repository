namespace DesignPattern.Builder
{
    public class ProductDirector
    {
        public void GenerateProduct(ProductBuilder productBuider)
        {
            productBuider.GetProductData();
            productBuider.ApplyDiscount();
        }

    }
}
