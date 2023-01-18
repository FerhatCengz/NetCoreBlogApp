using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }


        /*
            Blog ile Yorumlar arasında bir adet ilişki yapılandıracağım
            Örnek şöyle olacak: 
            Bir bloğun birden fazla yorumu olabilir.

            Yani burada birincil anahtar olarak gidip BlogID'yi yazmam gerekiyor

            Sistemde otomatik görünen bir birincil anahtar var zaten ben bunu liste yerine normal bir adet veri olarak
            Yapılandırırsam o zaman sistem gider arka tarafta otomatik olarak Primary Keyi alır

         */

        //Uzun lafı kısası Bu tabloya bir adet BlogID adında bir sutun eklemem lazım
        public int BlogID { get; set; }

        //Ve sonrasında Blog tablosunda ki bensersiz olan değeri eşleşmeye niteliyorum
        public Blog Blog { get; set; } // Buarada otomatik olarak Blog tablosunda ki BlogID gelecektir.



    }
}
