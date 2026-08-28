using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RoutePulse.Infrastructure;
using RoutePulse.Infrastructure.Persistances.Entities;

namespace RoutePulse.Application;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    private readonly ILogger<ApplicationDbContext> _logger;
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ILogger<ApplicationDbContext> logger) : base(options)
    {
        _logger = logger;
    }

    public DbSet<AddressEntity> Addresses => Set<AddressEntity>();
    public DbSet<CourierEntity> Couriers => Set<CourierEntity>();
    public DbSet<CustomerEntity> Customers => Set<CustomerEntity>();
    public DbSet<OrderEntity> Orders => Set<OrderEntity>();
    public DbSet<OrderItemEntity> OrderItems => Set<OrderItemEntity>();
    public DbSet<OrderStatusHistoryEntity> OrderStatusHistories => Set<OrderStatusHistoryEntity>();
    public DbSet<ProductEntity> Products => Set<ProductEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(InfrastructureAssemblyMarker).Assembly);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occured while async saving changes at {Time}", DateTime.UtcNow);
            throw;
        }
    }

    public override int SaveChanges()
    {
        try
        {
            return base.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occured while saving changes at {Time}", DateTime.UtcNow);
            throw;
        }
    }
}
