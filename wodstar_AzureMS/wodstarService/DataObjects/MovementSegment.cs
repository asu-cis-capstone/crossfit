using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace wodstarService.DataObjects
{
    public class MovementSegment : EntityData
    {
        public String segmentType;

        public String workoutId;

        public Movement[] segmentMovements;

        public String[] movementDescriptions;

        public String segmentHeader;

        public String segmentDescription;

        public int repetitions;
    }
}