using IPE.WhiteSmsTPL.Models.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.Responses.Notifications
{
    public class GetNotificationResponse : BaseResponse
    {
        public List<UserNotification> ListUserNotification { get; set; }
    }
}
