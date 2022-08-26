using Microsoft.AspNetCore.Mvc;
using SepeteYolla.Business.Concreate;
using SepeteYolla.Business.Fake;
using SepeteYolla.Entities;
using SepeteYolla.MVC.Models;
using System.Diagnostics;

namespace SepeteYolla.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            /*
            AdministratorManager administratorManager = new AdministratorManager();
            foreach (Administator item in FakeData.GetAdministrators(25))
            {
                administratorManager.CreateAdministrator(item);
            }
            
            CategoryManager categoryManager = new CategoryManager();
            foreach (Category item in FakeData.GetCategories(25))
            {
                categoryManager.CreateCategory(item);
            }

            CommentManager commentManager = new CommentManager();
            foreach (Comment item in FakeData.GetComments(25))
            {
                commentManager.CreateComment(item);
            }

            CompanyManager companyManager = new CompanyManager();
            foreach (Company item in FakeData.GetCompanies(25))
            {
                companyManager.CreateCompany(item);
            }

            CustomerManager customerManager = new CustomerManager();
            foreach (Customer item in FakeData.GetCustomers(25))
            {
                customerManager.CreateCustomer(item);
            }

            ProductManager productManager = new ProductManager();
            foreach (Product item in FakeData.GetProducts(25))
            {
                productManager.CreateProduct(item);
            }

            Product_KindManager product_KindManager = new Product_KindManager();
            foreach (Product_Kind item in FakeData.GetProduct_Kinds(25))
            {
                product_KindManager.CreateProduct_Kind(item);
            }

            PurchasedManager purchasedManager = new PurchasedManager();
            foreach (Purchased item in FakeData.GetPurchased(25))
            {
                purchasedManager.CreatePurchased(item);
            }

            Shopping_CartManager shopping_CartManager = new Shopping_CartManager();
            foreach (Shopping_Cart item in FakeData.GetShopping_Carts(25))
            {
                shopping_CartManager.CreateShopping_Cart(item);
            }
            */
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
    }
}