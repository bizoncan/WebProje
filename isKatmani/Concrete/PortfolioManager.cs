using isKatmani.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using varlikKatmani.Concrete;
using veriErisimK.Abstract;

namespace isKatmani.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void TAdd(portfolio t)
        {
            _portfolioDal.Insert(t);
        }

        public void TDelete(portfolio t)
        {
            _portfolioDal.Delete(t);
        }

        public portfolio TGetByID(int id)
        {
            return _portfolioDal.GetById(id);
        }

        public List<portfolio> TGetList()
        {
            return _portfolioDal.GetList();
        }

        public void TUpdate(portfolio t)
        {
            _portfolioDal.Update(t);
        }
        public List<portfolio> TGetLast5()
        {
            return _portfolioDal.GetList().OrderByDescending(x => x.portfolioID).Take(5).ToList();
        }

        public List<portfolio> TGetbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
