using Microsoft.Extensions.DependencyInjection;
using Challenge.Domain.Interfaces;
using Challenge.Domain;
using Challenge.Infra.Data.Repository;

namespace Challenge.Domain.Test
{
    public class DomainTestBase
    {
        public ServiceProvider provider { get; private set; }

        public DomainTestBase()
        {
            var service = new ServiceCollection();
            service.AddDomainServiceCollection();
            //service.AddInfraTestDataServiceCollection(); //MOCK
            service.AddInfraServiceCollection();

            provider = service.BuildServiceProvider();

            provider.GetService<IInitializeDomain>().Initialize(provider);
        }

    }
}
