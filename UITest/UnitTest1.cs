using Business.Concrete.Manager;
using DataAccess.Concrete.EntityFramework;
using NUnit.Framework;

namespace UITest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            EmployessManager _employessManager = new EmployessManager(new EfEmployeesDal());
            var result = _employessManager.GetList().Data.Count;
            Assert.AreEqual(result,result <= 100);
        }
    }
}