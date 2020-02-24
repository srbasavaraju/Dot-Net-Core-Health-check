using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Asp_Net_Health_Check.HealthCheck
{
    public class DatabaseHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {

            // Custom logic is no longer needed because  services.AddNpgSql(Configuration.GetConnectionString("MyWebApiConnectionString")) is suffice to handle
            throw new NotImplementedException();
        }
    }
}
