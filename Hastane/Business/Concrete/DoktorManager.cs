using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DoktorManager : IDoktorService
    {
        IDoktorDal _doktorDal;
        public DoktorManager(IDoktorDal doktorDal)
        {
            _doktorDal = doktorDal;
        }
        public IResult Add(Doktor doktor)
        {
            _doktorDal.Add(doktor);
            return new SuccessResult("Doktor Eklendi.");
        }

        public IResult Delete(Doktor doktor)
        {
            _doktorDal.Delete(doktor);
            return new SuccessResult("Doktor Silindi");
        }

        public IDataResult<List<Doktor>> GetAll()
        {
            return new SuccessDataResult<List<Doktor>>(_doktorDal.GetAll());
        }

        public IDataResult<List<DoktorDetail>> GetAllByTibbiBirimId(int birimId)
        {
            return new SuccessDataResult<List<DoktorDetail>>(_doktorDal.GetDoktorDetails(c => c.TibbiBirimId == birimId));
        }

        public IDataResult<Doktor> GetByID(int ID)
        {
            return new SuccessDataResult<Doktor>(_doktorDal.Get(c => c.DoktorId == ID));
        }

        public IDataResult<List<DoktorDetail>> GetDoktorDetailsById(int doktorId)
        {
            return new SuccessDataResult<List<DoktorDetail>>(_doktorDal.GetDoktorDetails(c => c.DoktorId == doktorId));
        }

        public IDataResult<List<DoktorDetail>> GetDoktorDetails()
        {
            return new SuccessDataResult<List<DoktorDetail>>(_doktorDal.GetDoktorDetails());
        }

        public IResult Update(Doktor doktor)
        {
            _doktorDal.Update(doktor);
            return new SuccessResult("Doktor Güncellendi");
        }
    }
}
