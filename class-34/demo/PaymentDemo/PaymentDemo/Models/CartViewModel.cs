namespace PaymentDemo.Models
{
	public class CartViewModel
	{
        public List<CartItem> CartItems { get; set; }

        public decimal OrderTotal { get; set; }

        public OrderInformation OrderInformation { get; set; }
    }
}
