using System;
using System.Collections.Generic;

namespace Notification.Db.Entities
{
    public class NotificationMessage : BaseEntity 
    {
        public Guid RecipientId { get; set; }

        public Guid SenderId { get; set; }

        public DateTime SendDateTime { get; set; }

        public string MessageBody { get; set; }

        public string Subject { get; set; }

        public IList<NotificationType> NotificationType { get; set; }

    }
}
