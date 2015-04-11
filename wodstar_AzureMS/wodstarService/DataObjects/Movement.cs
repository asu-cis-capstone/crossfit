using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace wodstarService.DataObjects
{
    public class Movement : EntityData
    {
        public String classification { get; set; }

        public String name { get; set; }

        public String equipment { get; set; }

        public String type { get; set; }

        public String blackDiamondDescription { get; set; }

        public String blueSquareDescription { get; set; }

        public String greenCircleDescription { get; set; }

        public String rxVideoUrl { get; set; }

        public String rxImageUrl { get; set; }

        public String blackDiamondVideoUrl { get; set; }

        public String blackDiamondImageUrl { get; set; }

        public String blueSquareVideoUrl { get; set; }

        public String blueSquareImageUrl { get; set; }

        public String greenCircleVideoUrl { get; set; }

        public String greenCircleImageUrl { get; set; }
    }
}