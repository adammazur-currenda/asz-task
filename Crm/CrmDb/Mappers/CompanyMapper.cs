using CrmDb.Model;
using FluentNHibernate.Mapping;

namespace CrmDb.Mappers
{
    public class CompanyMapper : ClassMap<Company>
    {
        public CompanyMapper()
        {
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}
