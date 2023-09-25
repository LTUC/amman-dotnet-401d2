using Microsoft.AspNetCore.Mvc;
using PaymentDemo.Models;
using Stripe.Checkout;
using Stripe;

namespace PaymentDemo.Controllers
{

	

	public class BuyProductController : Controller
	{

		private readonly IConfiguration _configuration;

        public BuyProductController(IConfiguration configuration)
        {
			_configuration = configuration;

		}

        private readonly List<CartItem> _items = new List<CartItem>()
		{
			new CartItem { ProductId = 1, ProductName = "Product A", Price = 10.99M, Quantity = 4},
			new CartItem { ProductId = 2, ProductName = "Product B", Price = 19.99M, Quantity = 2}
		};

		public IActionResult Index()
		{

			CartViewModel cartViewModel = new CartViewModel()
			{
				CartItems = _items
			};

			foreach (var item in cartViewModel.CartItems)
			{
				cartViewModel.OrderTotal += (item.Price * item.Quantity);
			}

			return View(cartViewModel);
		}

		public IActionResult Summary()
		{
			CartViewModel cartViewModel = new CartViewModel()
			{
				CartItems = _items,
				OrderInformation = new OrderInformation()
				{
					Name = "Anas Alrantisi",
					City = "Amman",
					PhoneNumber = "122323343243",
					PostalCode ="1234",
					UserId = 1,
					StreetAddress = "Amman"
					
				}

        };


            foreach (var item in cartViewModel.CartItems)
            {
                cartViewModel.OrderTotal += (item.Price * item.Quantity);
            }

            return View(cartViewModel);
		}

		[HttpPost]
		[ActionName("Summary")]
		public IActionResult SummaryPOST()
		{
			CartViewModel cartViewModel = new CartViewModel()
			{
				CartItems = _items,
				OrderInformation = new OrderInformation()
				{
					Name = "Anas Alrantisi",
					City = "Amman",
					PhoneNumber = "122323343243",
					PostalCode = "1234",
					UserId = 1,
					StreetAddress = "Amman"

				}
			};

			foreach (var item in cartViewModel.CartItems)
			{
				cartViewModel.OrderTotal += (item.Price * item.Quantity);
			}

			cartViewModel.OrderInformation.OrderDate = DateTime.Now;


			StripeConfiguration.ApiKey = _configuration.GetSection("StripeSettings:SecretKey").Get<string>();

			var domain = "https://localhost:7010/";

			var options = new SessionCreateOptions
			{
				SuccessUrl = domain + "BuyProduct/OrderConfirmation",
				CancelUrl = domain + "BuyProduct/Index",
				LineItems = new List<SessionLineItemOptions>(),
				Mode = "payment",
			};

			foreach (var item in cartViewModel.CartItems)
			{
				var sessionLineItem = new SessionLineItemOptions
				{
					PriceData = new SessionLineItemPriceDataOptions()
					{
						UnitAmount = (long)(item.Price * 100), // 20.50 => 2050
						Currency = "usd",
					    ProductData = new SessionLineItemPriceDataProductDataOptions()
						{
							Name = item.ProductName
						}
					},
					Quantity = item.Quantity
				};

				options.LineItems.Add(sessionLineItem);
			}

			var service = new SessionService();
			var session = service.Create(options);

			var sessionId = session.Id;

			TempData["sessionId"] = sessionId;


			Response.Headers.Add("Location", session.Url);

			return new StatusCodeResult(303);

		}

		public IActionResult OrderConfirmation(int OrderId = 5)
		{
			///var order OrderService.GetOrderInformation(OrderId);
			/// var sessionId = order.SessionId

			var sessionId = TempData["sessionId"].ToString();

			var service = new SessionService();

			Session session = service.Get(sessionId);
			
			if (session != null)
			{
				if (session.PaymentStatus.ToLower() == "paid")
				{
					return View();
				}
			}

			return Content("Not completed suucessfully");
			
		}

	}
}
