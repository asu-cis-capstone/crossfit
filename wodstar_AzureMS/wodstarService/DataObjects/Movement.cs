using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace wodstarService.DataObjects
{
    public class Movement : EntityData
    {
        public String Classification { get; set; }

        public String Name { get; set; }

        public String Equipment { get; set; }

        public String Type { get; set; }

        public String BlackDiamondDescription { get; set; }

        public String BlueSquareDescription { get; set; }

        public String GreenCircleDescription { get; set; }

        public String RxVideoUrl { get; set; }

        public String RxImageUrl { get; set; }

        public String BlackDiamondVideoUrl { get; set; }

        public String BlackDiamondImageUrl { get; set; }

        public String BlueSquareVideoUrl { get; set; }

        public String BlueSquareImageUrl { get; set; }

        public String GreenCircleVideoUrl { get; set; }

        public String GreenCircleImageUrl { get; set; }
    }
}