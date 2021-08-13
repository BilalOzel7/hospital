using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface ITibbiBirimService
    {
        IDataResult<List<TibbiBirim>> GetAll();
        IDataResult<TibbiBirim> GetByID(int ID);
        IResult Add(TibbiBirim tBirim);
        IResult Update(TibbiBirim tBirim);
        IResult Delete(TibbiBirim tBirim);
    }
}
