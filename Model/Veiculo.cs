using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho_AD.Model
{
    public class Veiculo
    {
        [Key]
        public int id { get; set; }
        public int ano { get; set; }
        public int idMarca  { get; set; }
        //[ForeignKey("idMarca")]
    }
}
