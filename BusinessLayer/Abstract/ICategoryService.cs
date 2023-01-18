using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    //Bussinsess katmanında ki abstract klasöürünün alıntaki interfaceler S SERVİCES olarak adlandırılıyor
    public interface ICategoryService
    {
        void CategoryAdd(Category category);
        void CategoryUpdate(Category category);
        void CategoryDelete(Category category);
        List<Category> CategoryGetList();
        Category CategoryGetByID(int id);
    }
}
