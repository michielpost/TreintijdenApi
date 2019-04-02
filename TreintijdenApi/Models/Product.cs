using System;
using System.Collections.Generic;
using System.Text;

namespace TreintijdenApi.Models
{
    public class Product
    {
        public string Number { get; set; }
        public string CategoryCode { get; set; }
        public string ShortCategoryName { get; set; }
        public string LongCategoryName { get; set; }
        public string OperatorCode { get; set; }
        public string OperatorName { get; set; }
        public ProductType Type { get; set; }
        public string DisplayName { get; set; }
    }

    public enum ProductType
    {
        UNKNOWN,
        TRAIN,
        BUS,
        TRAM,
        METRO,
        FERRY,
        WALK,
        BIKE,
        CAR,
        TAXI,
        SUBWAY
    }
}
