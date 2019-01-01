using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityAppApi.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        private int NumberOfPointsOfInterest;

        public int NumberOfPointsOfInterestmethod
        {
            get { return PointsOfInterest.Count; }
            set { NumberOfPointsOfInterest = value; }
        }


        public ICollection<PointOfInterestDto> PointsOfInterest { get; set; } = new List<PointOfInterestDto>();



    }
}
