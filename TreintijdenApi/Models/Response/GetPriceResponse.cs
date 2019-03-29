using System;
using System.Collections.Generic;
using System.Text;

namespace TreintijdenApi.Models.Response
{
    public class GetPriceResponse
    {
        public List<PriceOption> PriceOptions { get; set; }

    }

    public class Supplements
    {
        public int? Kaart { get; set; }
    }

    public class TotalPrice
    {
        public string ClassType { get; set; }
        public string DiscountType { get; set; }
        public string ProductType { get; set; }
        public double Price { get; set; }
        public Supplements Supplements { get; set; }
    }

    public class PriceOption
    {
        public string Type { get; set; }
        public int TariefEenheden { get; set; }
        public string Transporter { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public List<TotalPrice> TotalPrices { get; set; }
    }
}
