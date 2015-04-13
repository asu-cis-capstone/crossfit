using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace wodstarService.DataObjects
{
    public class WorkoutSegment : EntityData
    {
        public String SegmentType { get; set; }

        public String WorkoutId { get; set; }

        public String SegmentMovements { get; set; }

        public String MovementDescriptions { get; set; }

        public String SegmentHeader { get; set; }

        public String SegmentDescription { get; set; }

        public int Repetitions { get; set; }

        public int Time { get; set; }
    }
}