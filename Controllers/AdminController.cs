using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROJECT_WEB_ADMIN.Models;

namespace PROJECT_WEB_ADMIN.Controllers
{
    public class AdminController : Controller
    {
        WebEntities4 ctx = new WebEntities4();

        //GET: Admin 
        public ActionResult Dashboard()
        {
            List<Product> products = ctx.Products.ToList();

            //passing model to view
            return View(products);
        }



        public ActionResult AddProduct()
        {
            Product product = new Product();
            //list category 

            List<Product> product1 = ctx.Products.ToList();
            ViewBag.products1 = product1;

            List<Category> category = ctx.Categories.ToList();
            ViewBag.Category = category;



            return View(product);
        }

        public ActionResult SaveProduct(Product product)
        {
            //save to db
            ctx.Products.Add(product);
            ctx.SaveChanges();

            return RedirectToAction("Dashboard");

        }

        public ActionResult Products()
        {
            //1. db -> products
            //select * from products
            List<Product> products = ctx.Products.ToList();

            return View(products);
        }



        public ActionResult DeleteProduct(int ProductId)
        {

            Product product = ctx.Products.Where(t => t.ProductId == ProductId).SingleOrDefault();
            //xóa
            ctx.Products.Remove(product);
            ctx.SaveChanges();


            //redirect view
            return RedirectToAction("Dashboard");

        }



        public ActionResult ProductDetails(int id)
        {
            //select * from Products where 

            Product product = ctx.Products.Where(t => t.ProductId == id).SingleOrDefault();
            ViewBag.productID = id;



            //passing data /model to view

            return View(product);
        }



        [HttpGet]
        public ActionResult EditProduct(int ProductId)
        {

            // list category
            List<Category> categories = ctx.Categories.ToList();
            ViewBag.categories = categories;

            List<Product> product = ctx.Products.ToList();
            ViewBag.product = product;
            //select * from Toys where 

            Product products = ctx.Products.Where(t => t.ProductId == ProductId).SingleOrDefault();
            ViewBag.productID = ProductId;
            //passing data /model to view
            return View(products);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            //search old entity
            Product oldproduct = ctx.Products.Where(t => t.ProductId == product.ProductId).SingleOrDefault();
            // update
            oldproduct.Name = product.Name;
            oldproduct.Form = product.Form;
            oldproduct.Sex = product.Sex;
            oldproduct.Form = product.Form;
            oldproduct.Price = product.Price;
            oldproduct.Quantity = product.Quantity;
            oldproduct.Size = product.Size;
            oldproduct.Image = product.Image;

            ctx.SaveChanges();

            return RedirectToAction("Dashboard");
        }







        public ActionResult Customers()
        {
            List<Customer> customers = ctx.Customers.ToList();




            return View(customers);
        }




        //public ActionResult Index()
        // {

        // List<Product> lst = new List<Product>()
        // {
        //  new Product() { Name =  "Áo Thun ( Local Brand)", Size = " XL" },
        // new Product() { Name =  "Áo sơ mi ( Global Brand)",  Size = " XXL" },
        // new Product() { Name =  "Áo lưới ( VietNam Brand)",  Size = " L" },
        // new Product() { Name =  "Áo Ngủ ( ĐÔng Lào  Brand)",  Size = " 3XL" },
        // new Product() { Name =  "Quần jean ( Lmao Brand)",  Size = " L" }

        // };
        //passing data model to view
        // return View(lst);

        //}












        [HttpPost]
        public ActionResult AddProduct(Product product)
        {


            return View(product);
        }









    }
}