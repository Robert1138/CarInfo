using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
//    [EnableCors("https://webapplication320181208101119.azurewebsites.net")]
    

    [Route("api/[controller]")]
    public class CarController : Controller
    {

        VehiclesContext context;
        public CarController(VehiclesContext context)
        {
            this.context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        //  IEnumerable<vehiclesFEGOV>
        {
            List<string> li = new List<string>();


            var car_context = context;
            /*
            var query = car_context.Vehicles
                .Where(vehiclesFEGOV => vehiclesFEGOV.make == "Ford")
                .Select(vehiclesFEGOV => new { vehiclesFEGOV.model});

            foreach (var item in query)
            {
                li.Add(item.model);

            }
           
            car_context.Vehicles.ToList();
            */


            // var query = car_context.vehiclesFEGOV
            //                      .Where(vehiclesFEGOV => vehiclesFEGOV.id == 1125)
            //                    .Select(vehiclesFEGOV => vehiclesFEGOV.model).ToList();
            string make = "Acura";
            var query2 = from vehiclesFEGOV in car_context.vehiclesFEGOV
                         where vehiclesFEGOV.make.Equals(make)
                         select vehiclesFEGOV;

            var query = car_context.vehiclesFEGOV.FirstOrDefault<vehiclesFEGOV>();
            //this works
            //var query = car_context.vehiclesFEGOV
            //.Select(vehiclesFEGOV => vehiclesFEGOV.year)
            //.First();



            //var query2 = from carQ in vehiclesFEGOV
            //           select 





            return Ok(query);

            // this did work
            /*
             car_context.vehiclesFEGOV
                .Where(vehiclesFEGOV => vehiclesFEGOV.make == "Ford")
                .Select(vehiclesFEGOV => vehiclesFEGOV.model )
                .ToList(); 
              
           
             */

        }

        /*
        [HttpGet("{carName}")]
        public string getCar(string carName)
        {

            string carInfo = "";


            var car_context = context;

            var query = car_context.Vehicles
                .Where(vehiclesFEGOV => vehiclesFEGOV.make == "Ford" && vehiclesFEGOV.id == 1225)
                .Select(vehiclesFEGOV => new { vehiclesFEGOV.model });

            return carInfo;
        }
        */
        
        [HttpGet("{id}")]
        public async Task<IActionResult> getCarById(int id)
        {
            //IEnumerable<vehiclesFEGOV>


            var car_context = context;
            List<string> li = new List<string>();

            var query = car_context.vehiclesFEGOV
                      .Where(vehiclesFEGOV => vehiclesFEGOV.id == id);
            //.Select(vehiclesFEGOV => vehiclesFEGOV.make)
            //.Select(vehiclesFEGOV => new { vehiclesFEGOV.model })



            return Ok(car_context.vehiclesFEGOV.Find(id));
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
