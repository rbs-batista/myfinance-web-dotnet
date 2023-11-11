namespace myfinance_web_netcore.Domain
{

  public class Transacao
  {
    public int? Id { get; set; }
    public required string Historico { get; set; }
    public required string Tipo { get; set; }
    public required decimal Valor { get; set; }
    public int PlanocontaId { get; set; }
    public DateTime Data { get; set; }
    public required PlanoConta PlanoConta { get; set; }
  }

}