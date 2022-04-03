using Microsoft.EntityFrameworkCore;
using Bcnfolio.Database;

namespace Bcnfolio.Data
{
    public static class Extensions
    {
        public static IServiceCollection AddSynchronizingDataFactory(
            this IServiceCollection service) =>
            service.AddSingleton<ISummitTaskContextFactory, SynchronizedSummitDbContextFactory>();
    }
}