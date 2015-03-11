using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace wodstarService.DataObjects
{
    public class Movement : EntityData
    {
        public string id { get; set; }

        public string classification { get; set; }

        public string equipment { get; set; }

        public string type { get; set; }

        public string rxName { get; set; }

        public Uri rxLink { get; set; }

        public string blackDiamondName { get; set; }

        public Uri blackDiamondLink { get; set; }

        public string blueSquareName { get; set; }

        public Uri blueSquareLink { get; set; }

        public string greenCircleName { get; set; }

        public Uri greenCircleLink { get; set; }
    }
}