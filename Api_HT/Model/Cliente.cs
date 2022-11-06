using MessagePack.Formatters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_HT.Model
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "informe o CPF")]
        [StringLength(11, MinimumLength = 11)]
        public string cpf { get; set; }

        [Required(ErrorMessage = "informe o nome")]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "informe o Endereço")]
        [StringLength(50, MinimumLength = 3)]
        public string End { get; set; }

        [Required(ErrorMessage = "informe o nome")]
        [StringLength(50, MinimumLength = 3)]
        public string Tel { get; set; }
      
        [Required(ErrorMessage = "informe a idade")]
        [StringLength(2, MinimumLength = 1)]
        public string idade { get; set; }

        [Required(ErrorMessage = "informe o nome")]
        [StringLength(50, MinimumLength = 3)]
        public string email { get; set; }

        [Required(ErrorMessage = "informe o nome")]
        [StringLength(15, MinimumLength = 8)]
        public string senha { get; set; }


    }
    }
