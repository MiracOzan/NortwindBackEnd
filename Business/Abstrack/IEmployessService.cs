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
        IDataResult<Employees> GetById(int employessId);
        IDataResult<List<Employees>> GetList();
        IResult Add(Employees employess);
        IResult Delete(Employees employess);
        IResult Update(Employees employess);

        IResult TransactionalOperation(Employees product);
    }
}
