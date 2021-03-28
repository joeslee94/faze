using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAZE.Models
{
    public class FishCaught
    {
        public int FishCaughtId { get; set; }
        public string FishSpecies { get; set; }
        public DateTime TimeCaught { get; set; }
        public double WeightofFish { get; set; }
        public double LengthofFish { get; set; }
        public string TypeofBaitLure { get; set; }
        public string ColorofBaitLure { get; set; }
        public string RodBrand { get; set; }
        public DateTime TripDate { get; set; }

        public FishCaught()
        {

        }
    }
}
