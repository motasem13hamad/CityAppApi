using CityAppApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityAppApi.Controllers
{
    [Route("api/cities")]
    public class PointsOfInterestsController : Controller
    {
        [HttpGet("{cityId}/PointOfInterest")]

        public IActionResult GetPointOfInterest(int cityId)
        {


            var result = CitiesDataStore.CitiesDataStoreCurrent.Cities.FirstOrDefault(s => s.Id == cityId);

            if (result == null)
            {
                return NotFound();

            }
            else
            {
                return Ok(result.PointsOfInterest);
            }

        }


        [HttpGet("{cityId}/PointOfInterest/{PointOFInterestID}")]
        public IActionResult GetPointOfInterest(int cityId,int PointOFInterestID)
        {


            var result = CitiesDataStore.CitiesDataStoreCurrent.Cities.FirstOrDefault(s => s.Id == cityId);

            if (result == null)
            {
                return NotFound();

            }
            else
            {

               
               var postresult= result.PointsOfInterest.FirstOrDefault(s=>s.Id==PointOFInterestID);
                if (postresult==null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(postresult);
                }



            }

        }



    }
}
