using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;

namespace WebApplication3.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class BrowseController : ControllerBase
    {

        VehiclesContext context;
        public BrowseController(VehiclesContext context) {

            this.context = context; 
        }

       
        [HttpGet("{make}")]
        public async Task<IActionResult> getCarsFromMake(string make)
        {
            //IEnumerable<vehiclesFEGOV>


            var car_context = context;
            List<string> li = new List<string>();

            var query = car_context.vehiclesFEGOV
                      .Where(vehiclesFEGOV => vehiclesFEGOV.make == make);


            //.Select(vehiclesFEGOV => vehiclesFEGOV.make)
            //.Select(vehiclesFEGOV => new { vehiclesFEGOV.model })


            var query2 = from vehiclesFEGOV in car_context.vehiclesFEGOV
                         where vehiclesFEGOV.make.Equals(make)
                         select vehiclesFEGOV;


            return Ok(car_context.vehiclesFEGOV.Where(vehiclesFEGOV => vehiclesFEGOV.make.Equals(make)));
        }




    }
}