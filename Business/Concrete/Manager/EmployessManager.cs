using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstrack;
using Business.Constants;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Log4Net.Loggers;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstrack;
using Entities.Concrete;

namespace Business.Concrete.Manager
{
    public class EmployessManager : IEmployessService
    {
        private readonly IEmployessDal _employessDal;

        public EmployessManager(IEmployessDal employessDal)
        {
            _employessDal = employessDal;
        }

        public IDataResult<Employees> GetById(int employessId)
        {
            return new SuccessDataResult<Employees>(_employessDal.Get(p => p.EmployeeID == employessId));
        }

        [LogAspect(typeof(FileLogger))]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<Employees>> GetList()
        {
            return new SuccessDataResult<List<Employees>>(_employessDal.GetList().ToList());
        }

        [LogAspect(typeof(FileLogger))]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Add(Employees employess)
        {
            IResult result = BusinessRules.Run(CheckIfEmployessIdExists(employess.EmployeeID));
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

        [LogAspect(typeof(FileLogger))]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Delete(Employees employess)
        {
            _employessDal.Delete(employess);
            return new SuccessResult(Messages.EmployessDeleted);
        }

        [LogAspect(typeof(FileLogger))]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult Update(Employees employess)
        {
            _employessDal.Update(employess);
            return new SuccessResult(Messages.EmployessUpdated);
        }

        [LogAspect(typeof(FileLogger))]
        [LogAspect(typeof(DatabaseLogger))]
        public IResult TransactionalOperation(Employees employess)
        {
            _employessDal.Update(employess);
            _employessDal.Add(employess);
            return new SuccessResult(Messages.EmployessUpdated);
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            