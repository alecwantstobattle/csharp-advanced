namespace Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product // constraint to a given type or any sub classes
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}