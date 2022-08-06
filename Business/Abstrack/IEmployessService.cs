using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstrack
{
    public interface IEmployessService 
    {
        IDataResult<Employess> GetById(int employessId);
        IDataResult<List<Employess>> GetList();
        IResult Add(Employess employess);
        IResult Delete(Employess employess);
        IResult Update(Employess employess);

        IResult TransactionalOperation(Employess product);
    }
}
