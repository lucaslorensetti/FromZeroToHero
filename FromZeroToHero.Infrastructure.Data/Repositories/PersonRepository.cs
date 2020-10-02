using FromZeroToHero.Domain.Entities;
using FromZeroToHero.Domain.Repositories;
using FromZeroToHero.Infrastructure.Data.UoW;
using System.Collections.Generic;

namespace FromZeroToHero.Infrastructure.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public PersonRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Person> GetAll()
        {
            return _unitOfWork.GetMany<Person>(@"
select [Id], [FirstName], [LastName]
from [dbo].[Person]
");
        }
    }
}
