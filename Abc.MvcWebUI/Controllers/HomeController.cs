using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Abc.MvcWebUI.Entity;
using Abc.MvcWebUI.Models;

namespace Abc.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {

        DataContext _context = new DataContext();
        
        // GET: Home
        public ActionResult Index()
        {
            var urunler = _context.Products
                                .Where(i => i.IsHome && i.IsApproved)
                                .Select(i => new ProductModel()
                                {   Id = i.Id,
                                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                                    Description = i.Description.Length > 50 ? i.Description.Substring(0,47)+"...":i.Description,
                                    Price = i.Price,
                                    Stock = i.Stock,
                                    Image = i.Image,
                                    CategoryId = i.CategoryId
                                }).ToList();
            /*Listeye ise i.IsHome=true hem de isApproved true olanlar gelicek*/

            return View(urunler);
        }
            
                                
        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id==id).FirstOrDefault());
            /*todolist için enumer<list> zımbırtısı gerekli*/
        }
        public ActionResult List(int? id)
        {
            var urunler = _context.Products
                    .Where(i => i.IsApproved)
                    .Select(i => new ProductModel()
                    {
                        Id = i.Id,
                        Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                        Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                        Price = i.Price,
                        Stock = i.Stock,
                        Image = i.Image ?? "1.jpg", /* i.image == null? "1.jpg" : i.image*/
                        CategoryId = i.CategoryId
                    }).AsQueryable(); /*AsQueryable kullmak = yani gerçek vt. bir sorgu çalıştırmadım demek bu yüzden toList yerine bunu kullancz*/

            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }


            return View(urunler.ToList());
            /*Tüm liste isApproved true*/
        }

        public PartialViewResult GetCategories() /*Kategorileri getirtcek*/
        {
            return PartialView(_context.Categories.ToList());
        }
    }
}