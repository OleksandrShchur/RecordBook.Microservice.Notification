using Notification.Db.Enums;
using System;

namespace Notification.Db.Entities
{
    public class NotificationType : BaseEntity
    {
        public string Type { get; set; }

        public string Description { get; set; }

        public NotificationAccess Access { get; set; }

        public NotificationMessage NotificationMessage { get; set; }

        public Guid NotificationId { get; set; }
    }
}
