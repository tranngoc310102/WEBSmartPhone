using Microsoft.AspNetCore.Mvc;
using Model.DataAccess;
using System.Diagnostics;
using Web_Project.Models;
using Model.BusinessObject;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Storage;
using System.Text.Json;

namespace Web_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IProductRepository productRepository = new ProductRepository();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

			List<Product> products =  new List<Product>();
			using (var web = new ProjectContext())
            {
                products = (List<Product>)productRepository.GetAllProduct();
            }                       
                ViewBag.Products = products;
            string accid = HttpContext.Session.GetString("accid");
            string role = HttpContext.Session.GetString("Role");
            ViewBag.Role = role;
            ViewBag.accid = accid;
            return View();
        }
		public IActionResult FormLogin()
		{			
			return View();
		}
        [HttpPost]
        public IActionResult Login()
        {
            string username = HttpContext.Request.Form["username"];
            string pass = HttpContext.Request.Form["password"];
            using (var stock = new ProjectContext())
            {
                Account acc = stock.Accounts.Where(a => a.Username == username && a.Pass == pass).SingleOrDefault();
                if (acc != null)
                {
                    HttpContext.Session.SetString("accid", acc.AccountId.ToString());
                    HttpContext.Session.SetString("role", acc.Role.ToString());
                    return Redirect("/Home/Index");
                }
                else
                {
                    return Redirect("/Home/FormLogin");
                }
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/Home/Index");
        }
        [HttpPost]
        public IActionResult Signup()
        {
            string name = HttpContext.Request.Form["name"];
            string username = HttpContext.Request.Form["username"];
            string pass = HttpContext.Request.Form["pass"];
            string address = HttpContext.Request.Form["address"];
            string phone = HttpContext.Request.Form["phone"];
            int role = 2;
            var stock = new ProjectContext();
            Account a = stock.Accounts.Where(a => a.Username == username).SingleOrDefault();
            if (a != null)
            {
                TempData["mess"] = "Account is exsit";
                return RedirectToAction("FormLogin", "Home");
            }
            else
            {
                Account acc = new Account();
                acc.Username = username;
                acc.Address = address;
                acc.Phone = phone;
                acc.Pass = pass;
                acc.Role = role;
                acc.AccountName = name;
                IAccountRepository accountRepository = new AccountRepository();
                accountRepository.InsertAccount(acc);
                TempData["success"] = "Signup successfully";
                return Redirect("/Home/FormLogin");
            }
        }
        public IActionResult Checkout(int? pid)
        {
            string accid = HttpContext.Session.GetString("accid");
            if (string.IsNullOrEmpty(accid))
            {
                return RedirectToAction("FormLogin");
            }
            else
            {
                var stock = new ProjectContext();
                Product product = new Product();
                  product =  stock.Products.Where(p => p.ProductId == pid).SingleOrDefault();
                ViewBag.product = product;
                return View(product);
            }
        }
        [HttpPost]
        public IActionResult Checkout()
        {
            IProductRepository productRepository = new ProductRepository();
            IOrderRepository orderRepository = new OrderRepository();
            Order order = new Order();
            order.ProductId = int.Parse(HttpContext.Request.Form["pid"]);
            order.FullName= HttpContext.Request.Form["name"];
            order.Address = HttpContext.Request.Form["address"];
            order.Quantity = int.Parse(HttpContext.Request.Form["quantity"]);
            order.AccountId = int.Parse(HttpContext.Session.GetString("accid"));
            Product pro = productRepository.GetProduct((int)order.ProductId);
            order.Total= pro.Price * order.Quantity;
            order.Status = 0;
            order.OrderDate = DateTime.Now;
            TempData["order"] = "Order sucessfully!";
            orderRepository.InsertOrder(order);
            return Redirect("/Home/Index");
        }
        public IActionResult SearchCate(int? cateid)
        {
            if(cateid == null)
            {
                return NotFound();
            }
            ProjectContext stock = new ProjectContext();
            List<Product> products = stock.Products.Where(p => p.CategoryId == cateid.Value).ToList();
			HttpContext.Session.SetString("Products", JsonSerializer.Serialize(products));
			return RedirectToAction("Index");
		}
        public IActionResult Search(string? key)
        {
            if(key == null)
            {
                return NotFound();
            }
            ProjectContext stock = new ProjectContext();
            List<Product> pros = stock.Products.Where(p => p.ProductName.Contains(key)).ToList();
			HttpContext.Session.SetString("Products", JsonSerializer.Serialize(pros));
			return RedirectToAction("Index");
		}
        public IActionResult Order()
        {
            string accid = HttpContext.Session.GetString("accid");
            if(accid == null)
            {
                return Redirect("/Home/FormLogin");
            }
            else
            {
                int acid = int.Parse(accid);
                ProjectContext stock = new ProjectContext();
                List<Order> orders = stock.Orders.Where(o => o.AccountId ==  acid).ToList();
                ViewBag.Order = orders;
                return View();
            }
        }
        public IActionResult Profile()
        {
			string accid = HttpContext.Session.GetString("accid");
			if (accid == null)
			{
				return Redirect("/Home/FormLogin");
			}
			else
			{				
				return View();
			}
		}
        [HttpPost]
        public IActionResult EditProfile()
        {
            IAccountRepository accountRepository = new AccountRepository();
            ProjectContext context = new ProjectContext();
            int accid = int.Parse(HttpContext.Session.GetString("accid"));
            Account account = new Account();
            account = context.Accounts.Where(a => a.AccountId == accid).FirstOrDefault();
            account.AccountName = HttpContext.Request.Form["name"];
            account.Address = HttpContext.Request.Form["address"];
            account.Phone = HttpContext.Request.Form["phone"];
            account.Pass = HttpContext.Request.Form["pass"];
            accountRepository.Update(account);
            TempData["mess"] = "Update Successfully!";
            return RedirectToAction("Profile", "Home");
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
    }
}