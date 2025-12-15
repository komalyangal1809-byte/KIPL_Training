using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate double DiscountRule(double price);
namespace DELEGATES_CSHARP
{
    internal class Discount_service
    {
        public double FestivalDiscount(double price)
        {
            Console.WriteLine("Festival Discount Applying");
            return price * 0.9;
        }
        public double PremiumDiscount(double price)
        {
            Console.WriteLine("Premium Discount Applying");
            return price * 0.85;
        }
        public double CouponDiscount(double price)
        {
            Console.WriteLine("Coupon Discount Applying");
            return price-50;
        }
    }
}
