using FromZeroToHero.SharedKernel.Interfaces;
using System;
using System.Configuration;

namespace FromZeroToHero.Application.Services
{
    public class ConfigurationService : IConfigurationService
    {
        public string GetDatabaseConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["db"]?.ConnectionString
                ?? throw new Exception("Unable to get the database connection string.");
        }
    }
}
