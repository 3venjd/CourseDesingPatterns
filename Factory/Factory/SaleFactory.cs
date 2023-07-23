using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    // Creator
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }

    // Concrete creator
    public class StoreSaleFactory : SaleFactory
    {
        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            _extra= extra;
        }

        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }

    // ConcretProduct
    public class StoreSale : ISale
    {
        private decimal _extra;

        public StoreSale(decimal extra)
        {
            _extra = extra;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"The sell in store cost {total} with the extra {_extra} and the final total is {total + _extra}");
        }
    }

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

    public class InternetSale : ISale
    {
        private decimal _discount;

        public InternetSale(decimal discount)
        {
            _discount = discount; 
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"The sell in store cost {total} with the discount {_discount} and the final total is {total - _discount}");
        }
    }

    // Product
    public interface ISale
    {
        public void Sell(decimal total);
    }
}
