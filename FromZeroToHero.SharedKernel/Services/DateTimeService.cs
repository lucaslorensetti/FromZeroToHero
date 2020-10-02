using FromZeroToHero.SharedKernel.Interfaces;
using System;

namespace FromZeroToHero.SharedKernel.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
