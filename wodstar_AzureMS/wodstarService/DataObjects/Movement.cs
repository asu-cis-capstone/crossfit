using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace wodstarService.DataObjects
{
    public class Movement : EntityData
    {
        public string Classification { get; set; }

        public string Equipment { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public String RxDescription { get; set; }

        public String BlackDiamondDescription { get; set; }

        public String BlueSquareDescription { get; set; }

        public String GreenCircleDescription { get; set; }

        public String Url { get; set; }
    }
}