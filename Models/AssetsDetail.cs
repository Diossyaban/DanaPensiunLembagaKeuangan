using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class AssetsDetail
    {
        public string AssetNumberType { get; set; }
        public string SubAssetsNumber { get; set; }
        public string SubAssetsName { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public double? IntRate { get; set; }
        public string DaysAccr { get; set; }
        public double? FaceValue { get; set; }
        public double? AvgBookCost { get; set; }
        public double? BookCost { get; set; }
        public double? MarketPrice { get; set; }
        public double? MarketValue { get; set; }
        public double? ProfitShare { get; set; }
        public DateTime? EffectiveDt { get; set; }
    }
}
