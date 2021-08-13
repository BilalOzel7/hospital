using Core.Utilities.Results;
using Entities;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IDoktorService
    {
        IDataResult<List<Doktor>> GetAll();
        IDataResult<Doktor> GetByID(int ID);
        IResult Add(Doktor doktor);
        IResult Update(Doktor doktor);
        IResult Delete(Doktor doktor);
        IDataResult<List<DoktorDetail>> GetDoktorDetails();
        IDataResult<List<DoktorDetail>> GetAllByTibbiBirimId(int birimId);
        IDataResult<List<DoktorDetail>> GetDoktorDetailsById(int carId);


    }
}
