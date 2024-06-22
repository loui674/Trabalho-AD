using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho_AD.Model
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; } // Adicionando chave primária

        public bool Pago { get; set; }
        public int PrazoDias { get; set; }

        public int IdVeiculo { get; set; }
        [ForeignKey("IdVeiculo")]
        public virtual Veiculo Veiculo { get; set; } // Adicionando relacionamento com a entidade Veiculo

    }
}
