using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDoktorDal : EfEntityRepositoryBase<Doktor, HastaneContext>, IDoktorDal
    {
        public List<DoktorDetail> GetDoktorDetails(Expression<Func<DoktorDetail, bool>> filter = null)
        {
            using (HastaneContext context = new HastaneContext())
            {
                var result = from dr in context.Doktorlar
                             join tb in context.TibbiBirim
                             on dr.TibbiBirimId equals tb.TibbiBirimId
                             
                             select new DoktorDetail
                             {

                                 DoktorId = dr.DoktorId,
                                 TibbiBirimId = dr.TibbiBirimId,
                                 FirstName = dr.FirstName,
                                 LastName=dr.LastName,
                                 Unvan= dr.Unvan,
                                 BirimAd = tb.BirimAd,
                                 Ozgecmis=dr.Ozgecmis,
                                 
                                 DoktorImage = (from i in context.DoktorImage
                                             where dr.DoktorId == i.DoktorId
                                             select new DoktorImage { Id = i.Id, DoktorId = i.DoktorId, ImagePath = i.ImagePath }).ToList()


                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
