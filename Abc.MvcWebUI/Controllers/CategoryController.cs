using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Abc.MvcWebUI.Entity;

namespace Abc.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Category
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        // GET: Category/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]

        //Kaydet tıkladığımda bu action çalışır
        //[Bind()] kullanmasakta olurdu ama hangi datalar gelicek...
        //fazlası eksiği güvenlik için sıkıntılı olmaması açısından kontrol sağlar.
        public ActionResult Create([Bind(Include = "Id,Name,Desciription")] Category category)
        {
            if (ModelState.IsValid)               //burda tüm şartları sağlyosa sunucu ya kayıt sağlar 
                                                 //(Entity altındaki *Category.cs deki şartlar).
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category);       //*forma bilgileri yinede gönderimini sağlayan satır*
                                         //if de şart sağlanmazsa *forma bilgileri yinede gönderir* 
                                         //sunucuya kayıt etmez tekrar doldurmasın kullanıcı diye.
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int? id)                      //nullable yaptık int? ile boş değer atanabilir olarak ayarladık nasıl? *<int?>.
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); //id göndermessen sayayı hataya düşüryor "badrequest"
            }
            Category category = db.Categories.Find(id);      // id göre sorgula gelen id al  "Category category" bunun içine at
            if (category == null)                            // gelen id db'de yoksa not found ver " return HttpNotFound();"
            {
                return HttpNotFound();                      //aranılan sayfa bulnamadı gönder.
            }
            return View(category);
        }

        // POST: Category/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Desciription")] Category category)
        {
            if (ModelState.IsValid)//giriş hatasız doğru sa = valid se
            {
                db.Entry(category).State = EntityState.Modified;        //güncelledi  modified değiştirilir durum
                db.SaveChanges();                                       //güncellenen veri ile yeni ile değiştirilir.
                return RedirectToAction("Index");                       //İndex viewine kullanıcıya gönderir.
            }
            return View(category);                     //valid hatalı çalışmazsada formda bilgileri yollar sunucuya kayıt etmeden.
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost, ActionName("Delete")]//aslında delete oldugunu methodun ismini belirtmis ancak aşagıda
        [ValidateAntiForgeryToken]  //çağrılan get validate doğru ise güvenlik için kulmış 
                                    //yani get ile post arasındaki iletişim GETten çağrılan token konrol ediliyor
        public ActionResult DeleteConfirmed(int id)
        //Burada ise yukardaki delete-id GETmethotla karışmaması için 'DeleteConfirmed' kullanmış  "Overload method" 
        {
            Category category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
