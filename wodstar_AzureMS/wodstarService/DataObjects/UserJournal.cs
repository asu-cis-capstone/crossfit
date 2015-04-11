using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace wodstarService.DataObjects
{
    public class UserJournal : EntityData
    {
        public string userAccountId { get; set; }

        public string statType { get; set; }

        public string statName { get; set; }

        public string statResult { get; set; }

        public string entryType { get; set; }

        public string statId { get; set; }
    }
}