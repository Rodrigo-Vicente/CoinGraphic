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
        protected readonly ADDContext _Db;
        
        private IConfiguration _configuration;
        private ICoinBTCRepository _coinRepository;
        public CoinController(IConfiguration iconfig, ADDContext db, ICoinBTCRepository coinRepository)
        {
            _configuration = iconfig;
            _Db = db;
            _coinRepository = coinRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        //public void SaveCoinHistoric()
        //{
        //    _coinRepository.SaveCoinBTC();
        //}


        [HttpGet]
        public JsonResult CallApiCoin()
        {
            var historicBTC5y =  _coinRepository.GetHistoric();
            var historicBtc30days = _coinRepository.GetLast30Days();

             return Json( new { data5y = historicBTC5y, data30ds = historicBtc30days });
            
        }
    }
}
