using System.ComponentModel.DataAnnotations;

namespace Trabalho_AD.Model
{
    public class Cliente
    {
        [Key]
        public string nome { get; set; }
        public string tipoContrato  { get; set; }
        public int idVeiculo { get; set; }
    }
}
