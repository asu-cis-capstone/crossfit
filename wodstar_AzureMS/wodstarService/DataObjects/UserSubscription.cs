using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace wodstarService.DataObjects
{
    public class UserSubscription : EntityData
    {
        public string UserAccountId { get; set; }

        public String SubName { get; set; }

        public DateTime SubStartDate { get; set; }

        public DateTime SubEndDate { get; set; }
    }
}