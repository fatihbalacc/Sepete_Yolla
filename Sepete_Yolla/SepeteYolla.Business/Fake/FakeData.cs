using Bogus;
using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.Business.Fake
{
    public static class FakeData
    {
        private static List<Administator> _administrators;
        public static List<Administator> GetAdministrators(int number)
        {
            return _administrators = new Faker<Administator>().RuleFor(x => x.Id, a => a.IndexFaker).RuleFor(x => x.E_mail, a => a.Person.Email).RuleFor(x => x.Password,a=>a.Lorem.ToString()).Generate(number);
        }

        private static List<Category> _categories;
        public static List<Category> GetCategories(int number)
        {
            return _categories = new Faker<Category>().RuleFor(x => x.Id, a => a.IndexFaker).RuleFor(x => x.Category_Name, a => a.Commerce.Product()).Generate(number);
        }

        private static List<Comment> _comments;
        public static List<Comment> GetComments(int number)
        {
            return _comments= new Faker<Comment>().RuleFor(x => x.Id, a => a.IndexFaker).RuleFor(x => x.Commentary, a => a.System.CommonFileExt()).RuleFor(x => x.Evolation, a => a.Random.Bool()).RuleFor(x => x.Product_Id, a => a.Lorem.Random.Number(100)).RuleFor(x => x.Customer_Id, a => a.Lorem.Random.Number(100)).RuleFor(x => x.Company_Id, a => a.Lorem.Random.Number(100)).Generate(number);
        }

        private static List<Company> _companies;
        public static List<Company> GetCompanies(int number)
        {
            return _companies= new Faker<Company>().RuleFor(x => x.Id, a => a.IndexFaker).RuleFor(x => x.Brand, a => a.Company.CompanyName()).RuleFor(x => x.Name, a => a.Name.FullName()).RuleFor(x => x.E_mail, a => a.Person.Email).RuleFor(x => x.Password, a => a.Lorem.ToString()).RuleFor(x => x.City, a => a.Address.City()).RuleFor(x => x.Contact_Info, a => a.Address.FullAddress()).Generate(number);
        }

        private static List<Customer> _customers;
        public static List<Customer> GetCustomers(int number)
        {
            return _customers = new Faker<Customer>().RuleFor(x => x.Id, a => a.IndexFaker).RuleFor(x => x.E_mail, a => a.Person.Email).RuleFor(x => x.Password, a => a.Lorem.ToString()).RuleFor(x => x.Mobile_Phone, a => a.Phone.ToString()).RuleFor(x => x.Second_Phone, a => a.Phone.ToString()).RuleFor(x => x.Address, a => a.Address.FullAddress()).Generate(number);
        }

        private static List<Product> _products;
        public static List<Product> GetProducts(int number)
        {
            return _products = new Faker<Product>().RuleFor(x => x.Id, a => a.IndexFaker).RuleFor(x => x.Name, a => a.Person.FullName).RuleFor(x => x.Statement, a => a.Lorem.Paragraph()).RuleFor(x => x.Comment_Number, a => a.Random.Number(900)).RuleFor(x => x.Company_Id, a => a.Random.Number(600)).RuleFor(x => x.Category_Id, a => a.Random.Number(600)).Generate(number);
        }

        private static List<Product_Kind> _product_Kinds;
        public static List<Product_Kind> GetProduct_Kinds(int number)
        {
            return _product_Kinds = new Faker<Product_Kind>().RuleFor(x => x.Id, a => a.IndexFaker).RuleFor(x => x.Dimension, a => a.Random.Number(2000).ToString()).RuleFor(x => x.Color, a => a.Name.ToString()).RuleFor(x => x.Price, a => a.Random.Number(90000)).RuleFor(x => x.Company_Id, a => a.Random.Number(600)).RuleFor(x => x.Category_Id, a => a.Random.Number(600)).RuleFor(x => x.Product_Id, a => a.Random.Number(400)).Generate(number);
        }

        private static List<Purchased> _purchaseds;
        public static List<Purchased> GetPurchased(int number)
        {
            return _purchaseds = new Faker<Purchased>().RuleFor(x => x.Id, a => a.IndexFaker).RuleFor(x => x.Total_Price, a => a.Random.Number(2000)).RuleFor(x => x.Quantity, a => a.Random.Number(50)).RuleFor(x => x.Time, a => a.Date.Past()).RuleFor(x => x.Company_Id, a => a.Random.Number(600)).RuleFor(x => x.Customer_Id, a => a.Random.Number(600)).RuleFor(x => x.Product_Id, a => a.Random.Number(400)).Generate(number);
        }

        private static List<Shopping_Cart> _shopping_Carts;
        public static List<Shopping_Cart> GetShopping_Carts(int number)
        {
            return _shopping_Carts = new Faker<Shopping_Cart>().RuleFor(x => x.Id, a => a.IndexFaker).RuleFor(x => x.Quantity, a => a.Random.Number(20)).RuleFor(x => x.Company_Id, a => a.Random.Number(600)).RuleFor(x => x.Customer_Id, a => a.Random.Number(600)).RuleFor(x => x.Product_Id, a => a.Random.Number(400)).Generate(number);
        }
    }
}
