using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace wodstarService.DataObjects
{
    public class Workout : EntityData
    {
        public string id { get; set; }

        public string workoutName { get; set; }

        public string workoutType { get; set; }
    }
}