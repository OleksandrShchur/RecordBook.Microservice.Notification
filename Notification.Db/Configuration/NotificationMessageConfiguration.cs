using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notification.Db.Entities;

namespace Notification.Db.Configuration
{
    public class NotificationMessageConfiguration : IEntityTypeConfiguration<NotificationMessage>
    {
        public void Configure(EntityTypeBuilder<NotificationMessage> builder)
        {
            builder.HasMany(nm => nm.NotificationType)
                .WithOne(nt => nt.NotificationMessage);
        }
    }
}
