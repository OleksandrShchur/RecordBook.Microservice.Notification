using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notification.Shared.Entities;

namespace Notification.Shared.Configuration
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
