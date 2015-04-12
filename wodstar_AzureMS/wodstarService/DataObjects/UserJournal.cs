using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace wodstarService.DataObjects
{
    public class UserJournal : EntityData
    {
        public string UserAccountId { get; set; }

        public string StatType { get; set; }

        public string StatName { get; set; }

        public string StatResult { get; set; }

        public string EntryType { get; set; }

        public string StatId { get; set; }

        public DateTime StatDateTime { get; set; }
    }
}