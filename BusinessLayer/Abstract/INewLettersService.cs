using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface INewLettersService
    {
        void NewLetterAdd(NewLetter newLetter);
        /*
          void NewLetterUpdate(NewLetter newLetter);
          void NewLetterDelete(NewLetter newLetter);
          List<NewLetter> NewLetterGetList();
          NewLetter NewLetterGetByID(int id)
        */
    }
}
