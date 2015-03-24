using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace wodstarService.DataObjects
{
    public class Workout : EntityData
    {
        public string WorkoutName { get; set; }

        public string WorkoutType { get; set; }
    }
}