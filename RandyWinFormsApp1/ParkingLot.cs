using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RandyWinFormsApp1
{
    public class ParkingLot
    {
        [JsonPropertyName("parkId")]
        public string ParkId { get; set; } = "";
        [JsonPropertyName("areaId")]
        public string AreaId { get; set; } = "";
        [JsonPropertyName("areaName")]
        public string AreaName { get; set; } = "";
        [JsonPropertyName("parkName")]
        public string ParkName { get; set; } = "";
        [JsonPropertyName("totalSpace")]
        public int TotalSpace { get; set; }
        [JsonPropertyName("Display")]
        public string Display { get; set; } = "";
        [JsonPropertyName("surplusSpace")]
        public string SurplusSpace { get; set; } = "";
        [JsonPropertyName("payGuide")]
        public string PayGuide { get; set; } = "";
        [JsonPropertyName("introduction")]
        public string Introduction { get; set; } = "";
        [JsonPropertyName("address")]
        public string Address { get; set; } = "";
        [JsonPropertyName("wgsX")]
        public double WgsX { get; set; }
        [JsonPropertyName("wgsY")]
        public double WgsY { get; set; }
    }
    public class ParkingLotAPIResponse
    {
        [JsonPropertyName("parkingLots")]
        public List<ParkingLot> ParkingLots { get; set; } = new List<ParkingLot>();
    }
}
