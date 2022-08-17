using VoeAirlines.Entities.Enums;

namespace VoeAirlines.Entities
{
    public class Manutencao
    {
        public Manutencao(DateTime dataHora,TipoManutencao tipoManutencao , int aeronaveId, string? observacao = null)
        {

            DataHora = dataHora;            
            AeronaveId = aeronaveId;
            this.tipoManutencao = tipoManutencao;
            Observacao = observacao;
        }
        
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public TipoManutencao tipoManutencao { get; set; }
        public string? Observacao { get; set; }
        public int AeronaveId { get; set; }
       
        public Aeronave Aeronave { get; set; } = null!;
    }
}
