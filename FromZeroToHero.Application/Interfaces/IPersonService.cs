using FromZeroToHero.Application.ViewModels;
using System.Collections.Generic;

namespace FromZeroToHero.Application.Interfaces
{
    public interface IPersonService
    {
        List<PersonViewModel> GetAll();
    }
}
