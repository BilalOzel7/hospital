using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TibbiBirimManager : ITibbiBirimService
    {
        ITibbiBirimDal _birimDal;

        public TibbiBirimManager(ITibbiBirimDal birimDal)
        {
            _birimDal = birimDal;
        }

        public IResult Add(TibbiBirim tBirim)
        {
            _birimDal.Add(tBirim);
            return new SuccessResult("Tıbbi Birim Eklendi.");
        }

        public IResult Delete(TibbiBirim tBirim)
        {
            _birimDal.Delete(tBirim);
            return new SuccessResult("Tıbbi Birim Silindi.");
        }

        public IDataResult<List<TibbiBirim>> GetAll()
        {
            return new SuccessDataResult<List<TibbiBirim>>(_birimDal.GetAll());
        }

        public IDataResult<TibbiBirim> GetByID(int ID)
        {
            return new SuccessDataResult<TibbiBirim>(_birimDal.Get(c => c.TibbiBirimId == ID));
        }

        public IResult Update(TibbiBirim tBirim)
        {
            _birimDal.Update(tBirim);
            return new SuccessResult("Tıbbi Birim Güncellendi.");
        }
    }
}
