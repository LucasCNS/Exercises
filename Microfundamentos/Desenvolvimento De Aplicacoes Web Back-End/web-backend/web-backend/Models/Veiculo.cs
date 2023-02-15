using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_backend.Models
{
	[Table("Veiculos")]
	public class Veiculo
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "Obrigatório informar o nome.")]
		public string Nome { get; set; }
		[Required(ErrorMessage = "Obrigatório informar a placa.")]
		public string Placa { get; set; }
	}
}
