using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }


        /*
         Category tablosunda ki ID kısmını bir'den çok olarak alınacak
            Ve Category tablosuna ilişkil olması adına bir adet category tablosundan bir özellik eklemem
            lazım
         */

        public int CategoryID { get; set; }

        public Category Category { get; set; }
        /*
            Burada ise CategoryID adında bir sutun eklenir.
            Ve sisteme bu kodda 'public Category Category { get; set; }' şunu söylenir
            Benim Category tablom ile eşleş
            İyi tamam eşleşeyimde ne ile eşleşeyim ben nereden bileyim işte bu sırada 
            Category tablomda bir benseriz (Primary Key) yapım var sistem otomatik olarak onu bulur ve onun ile
            eşleşir

            Mesela "public List<Category> Category { get; set; }" olsaydı bu sefer bire-çok yerine çoka-çok olurdu
            Çünkü arka tarafta da 'public List<Blog> Blogs { get; set; }' bu kod var

            Ee ? 
            Bu sefer demeyecek mi ben hangi birini görüp ona konayım
         */



        //Comments (Yorum Tablosu) Kısmı İçin
        //Bu örnekten sonra Blog(Bire) - Çok(Comments tablosu) olacak şekilde yapılandıralım
        /*
            Nede olsa Yorumlar kısmı çok olmaayacak mı ?
            Evet Olacak !
            O zaman şöyle yapılandıracağız 

            "List<Comment> Comments{ get; set;}" Bu kod içeriğinde birden fazla sutun getireceği için sistem neyle eşeleceğini 
             bilmeyecek otomatik olarak bunu Frogein key olarak belirleyecek 
            
         */

        List<Comment> Comments { get; set; }

    }
}
