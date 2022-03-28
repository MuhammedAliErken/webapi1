using Cars.Business.Abstract;
using Cars.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cars.Business.Concrete;

namespace Cars.API.Controllers
{
    
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private ICarService _vehicleService;
      


        public VehiclesController()
        {
            _vehicleService= new CarManager();

        }
        
        

        [HttpGet("api/{vehicletype}")]
        public List<Vehicle> Get(string vehicletype)
        {
            return _vehicleService.GetVehicleType(vehicletype);
        }
       
        

    }
}
