using FromZeroToHero.Application.Interfaces;
using FromZeroToHero.Application.ViewModels;
using FromZeroToHero.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace FromZeroToHero.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public List<PersonViewModel> GetAll()
        {
            var people = _personRepository.GetAll();

            return people
                .Select(row => new PersonViewModel
                {
                    Id = row.Id,
                    FullName = $"{row.FirstName} {row.LastName}"
                })
                .ToList();
        }
    }
}
