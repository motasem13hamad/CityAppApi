using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityAppApi.Models;
namespace CityAppApi.Models
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore CitiesDataStoreCurrent { get; } = new CitiesDataStore();


        public CitiesDataStore()
        {

            Cities = new List<CityDto>() {
                new CityDto { Id=1, Name="Amman", Description=" City In Jordan", PointsOfInterest= new List<PointOfInterestDto>(){

                    new PointOfInterestDto{ Id=1, Name="Wast el balad", Description="wast el balas"},
                    
                } },




               new CityDto { Id=2, Name="New York", Description=" City In US", PointsOfInterest= new List<PointOfInterestDto>(){

                    new PointOfInterestDto{ Id=1, Name="the Empire State Building", Description="NYC"},

                } },
               new CityDto { Id=3, Name="Beriut", Description="City In Lebanon",  PointsOfInterest= new List<PointOfInterestDto>(){

                    new PointOfInterestDto{ Id=1, Name="sharee alhamra", Description="homus"},

                } },


            };
        }
    }
}
