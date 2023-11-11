using System.ComponentModel.DataAnnotations;

namespace myfinance_web_netcore.Models
{
    public class TransacaoModel
    {
        public int? Id { get; set; }
        public required string Historico { get; set; }
        public required string Tipo { get; set; }
        public required decimal Valor { get; set; }
        public int PlanocontaId { get; set; }
        public DateTime Data { get; set; }
        public IEnumerable<SelectListItem>? PlanoContas { get; set; } 
    }
}