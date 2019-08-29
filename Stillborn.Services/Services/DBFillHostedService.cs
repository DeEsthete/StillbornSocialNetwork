using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stillborn.Services.Services
{
    public class DBFillHostedService : IHostedService, IDisposable
    {
        private readonly Repositories.RepositoryService _repositoryService;

        public DBFillHostedService(Repositories.RepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            
            throw new NotImplementedException();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
