using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace DBRepository.Factory
{
    public interface IDesignTimeDbContextFactory<out TContext> where TContext : DbContext
    {
        TContext CreateDbContext([NotNull] string[] args);
    }
}
