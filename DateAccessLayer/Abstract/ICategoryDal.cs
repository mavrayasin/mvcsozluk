using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAccessLayer.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {
        //crud
        // type name();

        //List<Category> List();
        //void insert(Category p);
        //void update(Category p);
        //void delete(Category p);
    }
}
