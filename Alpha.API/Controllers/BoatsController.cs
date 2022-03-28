using Cars.Business.Abstract;
using Cars.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cars.Business.Concrete;

namespace Cars.API.Controllers
{
    
    [ApiController]
    public class BoatsController : ControllerBase
    {
        private ICarService _boatsService;

        public BoatsController()
        {
            _boatsService= new CarManager();

        }

        [HttpGet("api/[controller]/{color}")]
        
        public List<Boat> Get(string color)
        {
            return _boatsService.GetBoatByColor(color);
        }


    }
}
