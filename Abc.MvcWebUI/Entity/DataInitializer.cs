using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name="Kamera",Desciription="Kamera ürünleri"},
                new Category(){Name="Bilgisayar",Desciription="Bilgisayar ürünleri"},
                new Category(){Name="Elektronik",Desciription="Elektronik ürünleri"},
                new Category(){Name="Telefon",Desciription="Telefon ürünleri"},
                new Category(){Name="Beyaz Eşya",Desciription="Beyaz Eşya ürünleri"}

            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){Name="Tüplü Limon Ağacı Fidanı Fidanı Fidanı Fidanı Fidanı",Description=" Ürün Açıklaması Lorem ipsum dolor sit amet, consectetur adipisicing elit",Price=555,Stock=2,IsApproved=true,CategoryId=1,IsHome=true,Image="1.jpg"},
                new Product(){Name="Tüplü Limon Ağacı Fidanı Fidanı Fidanı Fidanı Fidanı",Description=" Ürün Açıklaması Lorem ipsum dolor sit amet, consectetur adipisicing elit.Lorem ipsum dolor sit amet, consectetur adipisicing elit",Price=4440,Stock=2,IsApproved=true,CategoryId=1,IsHome=true,Image="2.jpg"},
                new Product(){Name="Tüplü Elma Ağacı FidanıFidanı Fidanı Fidanı Fidanı",Description=" ",Price=560,Stock=0,IsApproved=false,CategoryId=1,Image="3.jpg"},
                new Product(){Name="Tüplü Limon Ağacı Fidanı",Description=" Ürün Açıklaması Lorem ipsum dolor sit amet, consectetur adipisicing elit.Lorem ipsum dolor sit amet, consectetur adipisicing elit",Price=10,Stock=50,IsApproved=true,CategoryId=1,IsHome=true,Image="4.jpg"},
                new Product(){ Name = "Canon Eos 700D + 18-55 Is Stm + Çanta + 16 Gb Hafıza Kartı",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =false , CategoryId = 1,Image = "5.jpg"},

                new Product(){Name="Tüplü Limon Ağacı Fidanı Fidanı Fidanı Fidanı Fidanı",Description=" Ürün Açıklaması Lorem ipsum dolor sit amet, consectetur adipisicing elit",Price=555,Stock=2,IsApproved=true,CategoryId=2,IsHome=true,Image="1.jpg"},
                new Product(){Name="Tüplü Limon Ağacı Fidanı Fidanı Fidanı Fidanı Fidanı",Description=" Ürün Açıklaması Lorem ipsum dolor sit amet, consectetur adipisicing elit.Lorem ipsum dolor sit amet, consectetur adipisicing elit",Price=4440,Stock=2,IsApproved=false,CategoryId=2,IsHome=true,Image="2.jpg"},
                new Product(){Name="Tüplü Elma Ağacı FidanıFidanı Fidanı Fidanı Fidanı",Description=" ",Price=560,Stock=0,IsApproved=false,CategoryId=2,Image="3.jpg"},
                new Product(){Name="Tüplü Limon Ağacı Fidanı",Description=" Ürün Açıklaması Lorem ipsum dolor sit amet, consectetur adipisicing elit.Lorem ipsum dolor sit amet, consectetur adipisicing elit",Price=10,Stock=50,IsApproved=true,CategoryId=2,Image="4.jpg"},
                new Product(){ Name = "Canon Eos 700D + 18-55 Is Stm + Çanta + 16 Gb Hafıza Kartı",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =false , CategoryId = 2,Image = "5.jpg"},

                new Product(){Name="Tüplü Limon Ağacı Fidanı Fidanı Fidanı Fidanı Fidanı",Description=" Ürün Açıklaması Lorem ipsum dolor sit amet, consectetur adipisicing elit",Price=555,Stock=2,IsApproved=true,CategoryId=3,Image="1.jpg"},
                new Product(){Name="Tüplü Limon Ağacı Fidanı Fidanı Fidanı Fidanı Fidanı",Description=" Ürün Açıklaması Lorem ipsum dolor sit amet, consectetur adipisicing elit.Lorem ipsum dolor sit amet, consectetur adipisicing elit",Price=4440,Stock=2,IsApproved=false,CategoryId=3,IsHome=true,Image="2.jpg"},
                new Product(){Name="Tüplü Elma Ağacı FidanıFidanı Fidanı Fidanı Fidanı",Description=" ",Price=560,Stock=0,IsApproved=false,CategoryId=3,Image="3.jpg"},
                new Product(){Name="Tüplü Limon Ağacı Fidanı",Description=" Ürün Açıklaması Lorem ipsum dolor sit amet, consectetur adipisicing elit.Lorem ipsum dolor sit amet, consectetur adipisicing elit",Price=10,Stock=50,IsApproved=true,CategoryId=3,Image="4.jpg"},
                new Product(){ Name = "Canon Eos 700D + 18-55 Is Stm + Çanta + 16 Gb Hafıza Kartı",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =false , CategoryId = 3,Image = "5.jpg"},

                new Product(){Name="Tüplü Limon Ağacı Fidanı Fidanı Fidanı Fidanı Fidanı",Description=" Ürün Açıklaması Lorem ipsum dolor sit amet, consectetur adipisicing elit",Price=555,Stock=2,IsApproved=true,CategoryId=4,IsHome=true,Image="1.jpg"},
                new Product(){Name="Tüplü Limon Ağacı Fidanı Fidanı Fidanı Fidanı Fidanı",Description=" Ürün Açıklaması Lorem ipsum dolor sit amet, consectetur adipisicing elit.Lorem ipsum dolor sit amet, consectetur adipisicing elit",Price=4440,Stock=2,IsApproved=false,CategoryId=4,IsHome=true,Image="2.jpg"},
                new Product(){Name="Tüplü Elma Ağacı FidanıFidanı Fidanı Fidanı Fidanı",Description=" ",Price=560,Stock=0,IsApproved=false,CategoryId=4,Image="3.jpg"},
                new Product(){Name="Tüplü Limon Ağacı Fidanı",Description=" Ürün Açıklaması Lorem ipsum dolor sit amet, consectetur adipisicing elit.Lorem ipsum dolor sit amet, consectetur adipisicing elit",Price=10,Stock=50,IsApproved=true,CategoryId=4,Image="4.jpg"},
                new Product(){ Name = "Canon Eos 700D + 18-55 Is Stm + Çanta + 16 Gb Hafıza Kartı",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =false , CategoryId = 4,Image = "5.jpg"},
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }

    }
}