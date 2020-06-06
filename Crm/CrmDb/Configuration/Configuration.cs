using FluentNHibernate.Cfg;
using NHibernate;

namespace CrmDb.Configuration
{
    public static class Configuration
    {
        public static ISessionFactory CreateSessionFactory()
        {
           return Fluently.Configure().BuildSessionFactory();
        }
    }
}
