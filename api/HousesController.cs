using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CIS174_TestCoreApp.Models;

namespace CIS174_TestCoreApp.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousesController : ControllerBase
    {
        public HouseViewModel[] house = new HouseViewModel[]
        {
            new HouseViewModel { id = 1, bedrooms = 4, squareFT = 1854, date = new DateTime(05/28/1973), flooring = "Carpet" },
            new HouseViewModel { id = 2, bedrooms = 3, squareFT = 1675, date = new DateTime(10/17/2015), flooring = "Hardwood" }
        };

        // GET: api/House
        [HttpGet]
        [Route("/api/house")]
        public IEnumerable<HouseViewModel> Get()
        {
            return house;
        }

        // GET: api/Houses/5
        [HttpGet("{id}", Name = "Get")]
        [Route("/api/house/{Id}")]
        public IActionResult Get(int id)
        {
            if (id >= 0 && id < house.Length)
            {
                return Ok(house[id]);
            }
            return NotFound();
        }

        // PUT: api/Houses/5
        [HttpPost]
        [Route("/api/house/create")]
        public IActionResult Post(HouseViewModel house)
        {
            new HouseViewModel { id = 3, bedrooms = 4, squareFT = 2691, date = new DateTime(05 / 11 / 1999), flooring = "Bamboo" };
            
            if (house.id == 3)
            {
                //return house;
            }

            return NotFound();
        }


    }
}
