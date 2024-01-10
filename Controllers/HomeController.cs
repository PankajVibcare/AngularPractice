using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    { 
        private readonly HomeInterface _homeInterface;
     public HomeController(HomeInterface homeInterface) 
        { 
            _homeInterface = homeInterface;
        }

        [HttpGet]
        public async Task <IActionResult> getDetails()
        {
            var result=await _homeInterface.Get();
            if(result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

    }
}
