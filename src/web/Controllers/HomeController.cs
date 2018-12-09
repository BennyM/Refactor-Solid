using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web.Models;
using web.Store;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly ProductDb products;

        public HomeController(
            ILogger<HomeController> logger,
            ProductDb products)
        {
            this.logger = logger;
            this.products = products;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult CreateOrder(OrderModel order)
        {
            logger.LogDebug("Received an order");

            List<Product> orderedProducts = new List<Product>();
            foreach (var orderedProduct in order.Products)
            {
                var product = products.Products.Single(x => x.Id == orderedProduct);
                orderedProducts.Add(product);
            }
            double price = orderedProducts.Sum(x => x.Price);
            logger.LogDebug("Calculated price for order {0}", price);

            double shippingPrice = 5;

            if (price > 50)
            {
                logger.LogDebug("Free shipping applied");

                shippingPrice = 0;
            }
            double discountAmount = 0;
            if (!string.IsNullOrWhiteSpace(order.DiscountCode))
            {
                logger.LogDebug("Discount specified {0}", order.DiscountCode);
                var discount = products.Discounts.Single(x => x.Code == order.DiscountCode);
                if (discount.DiscountPercentage.HasValue)
                {
                    discountAmount = price * discount.DiscountPercentage.Value;
                }
                else if (discount.FlatDiscountAmount.HasValue)
                {›
                else if (discount.FreeShipping.HasValue)
                    {
                        discountAmount = shippingPrice;
                    }
                    logger.LogDebug("Discount to apply {0}", discountAmount);
                }
                HandlePayment(order, price - discountAmount);
                foreach (var notification in CreateNotifications(order))
                {
                    notification.Send();
                }



                logger.LogDebug("Order processed");
                return Ok();
            }

            private void HandlePayment(OrderModel o, double total)
            {
                var gateway = CreatePaymentGateway(o);

                if (gateway is CreditCardService cc)
                {
                    ChargeCreditCard(cc, o, total);
                }
                else
                {
                    ChargePaypalAccount(gateway, o, total);
                }
            }

            private void ChargeCreditCard(CreditCardService cc, OrderModel o, double total)
            {
            }

            private void ChargePaypalAccount(IPaymentService gateway, OrderModel o, double total)
            {
            }


            private IPaymentService CreatePaymentGateway(OrderModel o)
            {
                if (!string.IsNullOrWhiteSpace(o.CreditCardNumber))
                {
                    return new CreditCardService();
                }
                return new PaypalService();
            }

            private IEnumerable<INotification> CreateNotifications(OrderModel model)
            {
                if (!string.IsNullOrWhiteSpace(model.MobilePhone))
                {
                    yield return new SmsNotification();
                }
                yield return new MailNotification();
            }
        }













    }
