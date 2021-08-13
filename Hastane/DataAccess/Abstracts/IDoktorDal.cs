
using Core.DataAccess;
using Entities;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
   public interface IDoktorDal : IEntityRepository<Doktor>
    {
        List<DoktorDetail> GetDoktorDetails(Expression<Func<DoktorDetail, bool>> filter = null);
    }
}
