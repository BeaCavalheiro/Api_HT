using System.ComponentModel.DataAnnotations;

namespace Api_HT.Model
{
    public class Destino
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "informe o nome do destino")]
        [StringLength(50, MinimumLength = 3)]
        public string Local{ get; set; }

        [Required(ErrorMessage = "informe o País")]
        [StringLength(50, MinimumLength = 3)]
        public string Pais { get; set; }

        [Required(ErrorMessage = "informe o Valor dos passeios")]
        public double valor { get; set; }

       
    }
}
