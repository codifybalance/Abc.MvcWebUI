using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class Category
    {
        public int Id { get; set; }
        //Data Annotations.--int araştır
        [DisplayName("Kategori Adi")]
        [StringLength(maximumLength:20,ErrorMessage ="en fazla 20 karakter girebilirsiniz.")]
        public string Name { get; set; }
        
        [DisplayName("Açıklama")]
        public string Desciription { get; set; }

        public List<Product> Products { get; set; }/*Bire çok ilişki*/
    }
}