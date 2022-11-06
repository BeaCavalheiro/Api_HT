using System.ComponentModel.DataAnnotations;

namespace Api_HT.Model
{
    public class Hospedagem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "informe o nome do hotel")]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "informe o Endereço")]
        [StringLength(50, MinimumLength = 3)]
        public string End { get; set; }

        [Required(ErrorMessage = "informe o nome")]
        [StringLength(50, MinimumLength = 3)]
        public string Tel { get; set; }

        [Required(ErrorMessage = "informe o nome")]
        [StringLength(50, MinimumLength = 3)]
        public string pais { get; set; }

        [Required(ErrorMessage = "informe o Valor dos passeios")]
        public double valor { get; set; }

    }
}
