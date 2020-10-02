using FromZeroToHero.Domain.Entities;
using System.Collections.Generic;

namespace FromZeroToHero.Domain.Repositories
{
    public interface IPersonRepository
    {
        List<Person> GetAll();
    }
}
