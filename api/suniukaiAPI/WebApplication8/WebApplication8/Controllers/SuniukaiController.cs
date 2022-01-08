using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    [ApiController]
    [Route("/")]
    public class SuniukaiController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public Suniukas GautiSuniuka()
        {
            int AtsitiktinisNumeris = new Random().Next(0, DB.Suniukai.Count);
            return DB.Suniukai[AtsitiktinisNumeris];
        }
    }
}