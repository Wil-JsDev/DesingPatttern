
namespace DesingPatternConsole.FactoryPattern
{
    // Creator
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }

    // Concrete Creator
    public class StoreSaleFactory : SaleFactory
    {
        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }

        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }

    // Concrete Creator 2
    public class InternetSaleFactory : SaleFactory
    {
        private decimal _discount;

        public InternetSaleFactory(decimal discount)
        {
            _discount = discount;
        }

        public override ISale GetSale()
        {
            return new InternetSale(_discount);
        }
    }

    // Concret Product
    public class StoreSale : ISale
    {
        private decimal _extra;

        public StoreSale(decimal extra)
        {
            _extra = extra;
        }
        public void Sell(decimal total)
        {
            Console.WriteLine($"la venta en tienda tiene un total{total + _extra}");
        }
    }


    public class InternetSale : ISale
    {
        private decimal _discount;

        public InternetSale(decimal discount)
        {
            _discount = discount;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en internet tiene un total de {total - _discount}");
        }
    }

    // Product
    public interface ISale
    {
        public void Sell(decimal total);
    }
}
