
using CoinGraphic.Context;
using CoinGraphic.Models;
using CoinGraphic.Repository.ICoinRepository;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace CoinGraphic.Repository.CoinRepository
{
    public class CoinRepository : ICoinBTCRepository
    {
        protected readonly ADDContext _Db;

        private IConfiguration _configuration;
        public CoinRepository(IConfiguration iconfig, ADDContext db)
        {
            _configuration = iconfig;
            _Db = db;
        }
      

        public List<CoinHistoric5Y> GetHistoric()
        {
            var data = _Db.CoinHistoric5ys.OrderBy(x=>x.time_close).ToList();
            if(!data.Any())
            {
                SaveCoinBTC5years();
                var coinData = _Db.CoinHistoric5ys.OrderBy(x => x.time_close).ToList();
                return coinData;
            }

            return data;
        }

        public List<CoinHistoricLast30Days> GetLast30Days()
        {
            var data = _Db.CoinHistoricLast30Days.OrderBy(x => x.time_close).ToList();
            if (!data.Any())
            {
                SaveCoinBTCLast30Days();
                var coinData = _Db.CoinHistoricLast30Days.OrderBy(x => x.time_close).ToList();
                return coinData;
            }

            return data;
        }
        public void SaveCoinBTC5years()
        {
            CoinHistoric5Y coin = new CoinHistoric5Y();
            var tokenApi = _configuration.GetValue<string>("API:token");
            var client = new RestClient("https://rest.coinapi.io/v1/ohlcv/BITSTAMP_SPOT_BTC_USD/history?period_id=1MTH&time_start=2018-01-01T00:00:00");
            var request = new RestRequest();
            request.AddHeader("X-CoinAPI-Key", tokenApi);
            var response = client.Execute(request);
            if (response.IsSuccessStatusCode)
            {
                var data = JArray.Parse(response.Content);
                foreach (var item in data)
                {
                    coin.CoinId = Guid.NewGuid();
                    coin.time_close = item.Value<DateTime>("time_close");
                    coin.price_open = item.Value<decimal?>("price_open");
                    coin.price_high = item.Value<decimal?>("price_high");
                    coin.price_low = item.Value<decimal?>("price_low");
                    coin.price_close = item.Value<decimal?>("price_low");
                    coin.volume_traded = item.Value<decimal?>("volume_traded");

                    _Db.Add(coin);
                    _Db.SaveChanges();
                }
            }
        }
        public void SaveCoinBTCLast30Days()
        {
            CoinHistoricLast30Days coin = new CoinHistoricLast30Days();
            var startday = DateTime.Today.AddMonths(-1).ToString("yyyy-MM-dd");
            var endday = DateTime.Today.AddMonths(0).ToString("yyyy-MM-dd"); 
            var tokenApi = _configuration.GetValue<string>("API:token");
            var client = new RestClient($"https://rest.coinapi.io/v1/ohlcv/BITSTAMP_SPOT_BTC_USD/history?period_id=1DAY&time_start={startday}&time_end={endday}");
            var request = new RestRequest();
            request.AddHeader("X-CoinAPI-Key", tokenApi);
            var response = client.Execute(request);
            if (response.IsSuccessStatusCode)
            {
                var data = JArray.Parse(response.Content);
                foreach (var item in data)
                {
                    coin.CoinId = Guid.NewGuid();
                    coin.time_close = item.Value<DateTime>("time_close");
                    coin.price_open = item.Value<decimal?>("price_open");
                    coin.price_high = item.Value<decimal?>("price_high");
                    coin.price_low = item.Value<decimal?>("price_low");
                    coin.price_close = item.Value<decimal?>("price_low");
                    coin.volume_traded = item.Value<decimal?>("volume_traded");

                    _Db.Add(coin);
                    _Db.SaveChanges();
                }
            }
        }

    }
}
