using System.ComponentModel.DataAnnotations;

namespace Aula_03_11.Components.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Informe o nome do produto.")]
        public string Nome { get; set; } = "";

        [Range(typeof(decimal), "0", "79228162514264337593543950335",
            MinimumIsExclusive = true, ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal Preco { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser maior que zero.")]
        public int Quantidade { get; set; }
    }
}
