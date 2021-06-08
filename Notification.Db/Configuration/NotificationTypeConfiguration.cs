using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notification.Db.Entities;

namespace Notification.Db.Configuration
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
