using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewLetterManager : INewLettersService
    {
        INewsLetterDAL _newLatter;

        public NewLetterManager(INewsLetterDAL newLatter)
        {
            _newLatter = newLatter;
        }

        public void NewLetterAdd(NewLetter newLetter)
        {
            _newLatter.Insert(newLetter);
        }
    }
}
