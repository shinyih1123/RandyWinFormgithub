using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RandyWinFormsApp1.DataModels
{
    public class Calendar2
    {
        [JsonPropertyName("date")] // date --> Date
        public string Date { get; set; } = "";
        public string Chinese { get; set; } = "";
        [JsonPropertyName("isHoliday")] // isHoliday --> IsHoliday
        public bool IsHoliday { get; set; }
        public string Category { get; set; } = "";
        [JsonPropertyName("description")] // description --> Description
        public string Description { get; set; } = "";
        public string HolidayType { get; set; } = "";
        [JsonPropertyName("week")] // week --> Week
        public string Week { get; set; } = "";
        


    }
    //public class CalendarLotAPIResponse
    //{
    //    [JsonPropertyName("calendarLots")]
    //    public List<CalendarLot> CalendarLots { get; set; } = new List<CalendarLot>();
    //}
}
