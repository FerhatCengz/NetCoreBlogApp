using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }


        public List<Blog> Blogs { get; set; }

        /*
            Burada Blogs Tablosunun List olarak belirtmememizin sebebi
            Veri tabanında ki List olarak Blogs Tabolsunda ki Tüm Sutunları birden çekmektir 
            
            Burada ki Blogs tablosunun Bir-Çok ilişkiyi tanımlarken Çok olmasının sebebi
            Blogs tablosunun birden fazla özellikler içermesidir

            Mesela : BlogID alacağım ve ya CategoryID mi alacağım BlogImage mi alacağım sistem arka tarafta bilmiyor
            
            Bu kod yerine mesela 

            "public int Blog BlogID { get; set; }"
            olsaydı bu sefer sistem iki tarafta da biliyor ki ikisi birincil anahtar o zaman bire-çok ilişki sergilerdi.
         
         */


    }
}
