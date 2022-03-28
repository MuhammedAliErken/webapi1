using Cars.Business.Abstract;
using Cars.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cars.Business.Concrete;

namespace Cars.API.Controllers
{

    [ApiController]
    public class BussesController : ControllerBase
    {
        private ICarService _bussesService;

        public BussesController()
        {
            _bussesService= new CarManager();

        }

        [HttpGet("api/[controller]/{color}")]

        public List<Bus> Get(string color)
        {
            return _bussesService.GetBusByColor(color);
        }

        

    }
}
