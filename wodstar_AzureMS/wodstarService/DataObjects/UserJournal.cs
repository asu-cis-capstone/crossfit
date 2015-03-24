using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace wodstarService.DataObjects
{
    public class UserJournal : EntityData
    {
        public string userAccountId;

        public string statType { get; set; }

        public string statName { get; set; }

        public string statResult { get; set; }
    }
}