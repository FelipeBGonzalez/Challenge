using Microsoft.Extensions.DependencyInjection;
using Challenge.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace Challenge.Domain
{
    public class InitializeDomain : IInitializeDomain
    {
        public void Initialize(ServiceProvider _provider)
        {
            if (DomainBase.provider == null)
                DomainBase.provider = _provider;
        }
    }
}
