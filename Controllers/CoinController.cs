using CoinGraphic.Context;
using CoinGraphic.Repository.ICoinRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Threading.Tasks;

namespace CoinGraphic.Controllers
{
    public class CoinController : Controller
    {
        private ICoinBTCRepository _coinRepository;
        public CoinController(ICoinBTCRepository coinRepository)
        {
            _coinRepository = coinRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult CoinHistoricValues()
        {
            var historicBTC5y =  _coinRepository.GetHistoric();
            var historicBtc30days = _coinRepository.GetLast30Days();

             return Json( new { data5y = historicBTC5y, data30ds = historicBtc30days });
            
        }
    }
}
