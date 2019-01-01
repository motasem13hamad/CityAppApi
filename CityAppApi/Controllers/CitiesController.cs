using CityAppApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityAppApi.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {


        [HttpGet()]
        public IActionResult GetCities()
        {
            var result = CitiesDataStore.CitiesDataStoreCurrent;

            if (result == null)
            {
                return NotFound();

            }
            else { return Ok(result); }

        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {


            var result = CitiesDataStore.CitiesDataStoreCurrent.Cities.FirstOrDefault (s => s.Id == id);

            if (result == null)
            {
                return NotFound();

            }
            else { return Ok(result); }
        }
    }
}
