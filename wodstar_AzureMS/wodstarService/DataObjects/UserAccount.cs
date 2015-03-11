using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace wodstarService.DataObjects
{
    public class UserAccount : EntityData
    {
        public string Id { get; set; }
        public string Username { get; set; }

        public string AccountType { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }
    }
}