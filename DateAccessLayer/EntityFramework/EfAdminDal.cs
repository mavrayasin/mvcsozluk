using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateAccessLayer.Abstract;
using DateAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace DateAccessLayer.EntityFramework
{
    public class EfAdminDal:GenericRepository<Admin>,IAdminDal
    {
    }
}
