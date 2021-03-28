using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FAZE.Models
{
    //[Index(nameof(TripId), nameof(Date))]
    public class FishingTrip
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan TimeSpentFishing { get; set; }
        public int TotalFishCaught { get; set; }
        public int? NumOfBites { get; set; }
        public int? NumOfBaitUsed { get; set; }
        public string Season { get; set; }
        public double? AvgTemp { get; set; }
        public string WeatherConditions { get; set; }
        public string MoonPhase { get; set; }
        public string Tide { get; set; }
        public string Comments { get; set; }
        [ForeignKey("UsersFK")]
        public Users FKUsersId { get; set; }
        
        public FishingTrip()
        {

        }
    }
}
