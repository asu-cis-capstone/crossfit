using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace wodstarService.DataObjects
{
    public class WorkoutSegment : EntityData
    {
        public String segmentType { get; set; }

        public String workoutId { get; set; }

        public String segmentMovements { get; set; }

        public String movementDescriptions { get; set; }

        public String segmentHeader { get; set; }

        public String segmentDescription { get; set; }

        public int repetitions { get; set; }

        public int time { get; set; }
    }
}