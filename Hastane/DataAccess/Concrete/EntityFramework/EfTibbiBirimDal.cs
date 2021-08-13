using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfTibbiBirimDal : EfEntityRepositoryBase<TibbiBirim, HastaneContext>, ITibbiBirimDal
    {
    }
}
