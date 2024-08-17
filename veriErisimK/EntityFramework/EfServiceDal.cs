using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using varlikKatmani.Concrete;
using veriErisimK.Abstract;
using veriErisimK.Repository;

namespace veriErisimK.EntityFramework
{
    public class EfServiceDal : GenericRepository<service>, IServiceDal
    {
    }
}
