using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleEstoque.API.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataPedido {get; set; } = DateTime.Now;
        [Required, StringLength(20)]
        public string Status { get; set; }  // Aberto, Fechado;

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [ForeignKey("Caixa")]
        public int CaixaId { get; set; }
        public Caixa Caixa { get; set; }

        public ICollection<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
    }
}
