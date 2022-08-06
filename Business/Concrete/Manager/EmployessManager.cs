using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstrack;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstrack;
using Entities.Concrete;

namespace Business.Concrete.Manager
{
    public class EmployessManager : IEmployessService
    {
        private IEmployessDal _employessDal;
        public IDataResult<Employess> GetById(int employessId)
        {
            return new SuccessDataResult<Employess>(_employessDal.Get(p => p.EmployeeID == employessId));
        }

        public IDataResult<List<Employess>> GetList()
        {
            return new SuccessDataResult<List<Employess>>(_employessDal.GetList().ToList());
        }

        public IResult Add(Employess employess)
        {
            IResult result = BusinessRules.Run(CheckIfEmployessIdExists(employess.EmployeeID), CheckIfEmployessIsEnabled());
            if (result != null)
            {
                return result;
            }
            _employessDal.Add(employess);
            return new SuccessResult(Messages.EmployessAdded);
        }

        private object CheckIfEmployessIsEnabled()
        {
            var result = _employessDal.GetList();
            if (result.Count < 10)
            {
                return new ErrorResult(Messages.EmployeeIdAlreadyExists);
            }

            return new SuccessResult();
        }

        private IResult CheckIfEmployessIdExists(int employeeId)
        {
            var result = _employessDal.GetList(p => p.EmployeeID == employeeId).Any();
            if (result)
            {
                return new ErrorResult(Messages.EmployeeIdAlreadyExists);
            }

            return new SuccessResult();
        }

        public IResult Delete(Employess employess)
        {
            _employessDal.Delete(employess);
            return new SuccessResult(Messages.EmployessDeleted);
        }

        public IResult Update(Employess employess)
        {
            _employessDal.Update(employess);
            return new SuccessResult(Messages.EmployessUpdated);
        }

        public IResult TransactionalOperation(Employess employess)
        {
            _employessDal.Update(employess);
            _employessDal.Add(employess);
            return new SuccessResult(Messages.EmployessUpdated);
        }
    }
}
