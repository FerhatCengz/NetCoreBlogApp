using DataAccsessLayer.Abstract;
using DataAccsessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFreamwork
{
    public class EfNewsLetterRepository : GenericRepository<NewLetter> , INewsLetterDAL
    {

    }
}
