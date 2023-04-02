using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage = "Please enter a sales price.")]
        [Range(1, 500, ErrorMessage =
               "Sales price must be greater than 0 and less  500")]
        public decimal? SalesPrice { get; set; }

        [Required(ErrorMessage = "Please enter a discount percent")]
        [Range(0.1, 100.0, ErrorMessage =
               "Discount Percent must be between 0 and 100")]
        public decimal? DiscountPercent { get; set; }

        public decimal? CalculateDiscount()
        {
            decimal? discountAmount = SalesPrice * (DiscountPercent / 100.0m);
            return discountAmount;
        }
        public decimal? CalculateTotal()
        {
            return SalesPrice - CalculateDiscount();
        }
    }
}
