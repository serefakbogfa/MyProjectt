using DataAccess.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();


        public List<Category> GetAllBll()
        {
            return repo.List();
        }
        public void CategoryAddBL(Category p)
        {



            if (p.CategoryName == "" ||
                p.CategoryName.Length <= 3
                || p.CategoryDesciption == "" || p.CategoryDesciption.Length <=51)
            {

            }
            else
            {
                repo.Insert(p);

            }
        }
    }
}
