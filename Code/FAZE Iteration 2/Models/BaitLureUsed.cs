using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAZE.Models
{
    public class BaitLureUsed
    {
        public string BaitLureUsedId { get; set; }
        public double BaitLurePricePerPackage { get; set; }
        public int BaitLureQuantityPerPackage { get; set; }
        public int TotalFishCaughtbyBaitLure { get; set; }
        public DateTime TripDate { get; set; }

        public BaitLureUsed()
        {

        }

    }
}
