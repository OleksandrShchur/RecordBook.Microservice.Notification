using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notification.Shared.Entities;

namespace Notification.Shared.Configuration
{
    public class NotificationTypeConfiguration : IEntityTypeConfiguration<NotificationType>
    {
        public void Configure(EntityTypeBuilder<NotificationType> builder)
        {
            builder.HasOne(nt => nt.NotificationMessage)
                .WithMany(nm => nm.NotificationType);
        }
    }
}
