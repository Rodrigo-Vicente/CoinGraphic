using CoinGraphic.Models;

namespace CoinGraphic.Repository.ICoinRepository
{
    public interface ICoinBTCRepository
    {
        void SaveCoinBTC5years();
        public List<CoinHistoric5Y> GetHistoric();
        public List<CoinHistoricLast30Days> GetLast30Days();
        void SaveCoinBTCLast30Days();
    }
}
