using Microsoft.EntityFrameworkCore;
using Notification.Db.Entities;
using System.Reflection;

namespace Notification.Db.EFCore
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<NotificationType> NotificationTypes { get; set; }

        public DbSet<NotificationMessage> Notifications { get; set; }        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
