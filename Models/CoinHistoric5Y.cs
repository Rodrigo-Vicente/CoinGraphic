using System.ComponentModel.DataAnnotations;

namespace CoinGraphic.Models
{
    public class CoinHistoric5Y
    {
        [Key]
        public Guid CoinId { get; set; }

        //Hora da última negociação dentro do intervalo do período
        public DateTime? time_close { get; set; }

        //Primeiro preço de negociação dentro do intervalo do período
        public decimal? price_open { get; set; }

        //Preço mais alto negociado dentro do intervalo do período
        public decimal? price_high { get; set; }

        //Preço mais baixo negociado dentro do intervalo do período
        public decimal? price_low { get; set; }

        //Último preço de negociação dentro do intervalo do período
        public decimal? price_close { get; set; }

        //Valor base acumulado negociado dentro do intervalo do período
        public decimal? volume_traded { get; set; }

    }
}
