using System.ComponentModel.DataAnnotations;

namespace Api_HT.Model
{
    public class Transporte
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "informe o Aeroporto ou rodoviaria")]
        [StringLength(100, MinimumLength = 3)]
        public string aer_rod { get; set; }

        [Required(ErrorMessage = "horario de embarque")]
        [StringLength(50, MinimumLength = 3)]
        public string horario { get; set; }

        [Required(ErrorMessage = "informe o numero de embarque")]
        [StringLength(50, MinimumLength = 3)]
        public string codembarque { get; set; }

        [Required(ErrorMessage = "informe a companhia")]
        [StringLength(50, MinimumLength = 3)]
        public string companhia { get; set; }

        [Required(ErrorMessage = "informe data de ida")]
        [StringLength(8, MinimumLength = 6)]
        public string dida { get; set; }

        [Required(ErrorMessage = "informe data de volta")]
        [StringLength(8, MinimumLength = 6)]
        public string dvolta { get; set; }

        [Required(ErrorMessage = "informe o Valor do transporte")]
        public double valor { get; set; }

    }
}
