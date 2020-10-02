using FromZeroToHero.Application.Interfaces;
using FromZeroToHero.Application.Services;
using FromZeroToHero.Domain.Repositories;
using FromZeroToHero.Infrastructure.Data.Repositories;
using FromZeroToHero.Infrastructure.Data.UoW;
using FromZeroToHero.SharedKernel.Interfaces;
using SimpleInjector;
using System;

namespace FromZeroToHero.UI.Forms
{
    static class Program
    {
        private static Container container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            System.Windows.Forms.Application.Run(container.GetInstance<Form1>());
        }

        private static void Bootstrap()
        {
            // Create the container as usual.
            container = new Container();

            // Register your types, for instance:
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Singleton);
            container.Register<IConfigurationService, ConfigurationService>(Lifestyle.Singleton);
            container.Register<IPersonRepository, PersonRepository>(Lifestyle.Singleton);
            container.Register<IPersonService, PersonService>(Lifestyle.Singleton);
            container.Register<Form1>();

            // Optionally verify the container.
            container.Verify();
        }
    }
}
