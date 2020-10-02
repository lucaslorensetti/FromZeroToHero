using System.Collections.Generic;

namespace FromZeroToHero.Infrastructure.Data.UoW
{
    public interface IUnitOfWork
    {
        List<T> GetMany<T>(string sql, params object[] parameters) where T : class;
        T GetOne<T>(string sql, params object[] parameters) where T : class;
    }
}
