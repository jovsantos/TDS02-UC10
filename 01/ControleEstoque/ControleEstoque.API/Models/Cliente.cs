using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.API.Models
{
    public class Cliente : Usuario
    {
        [StringLength(14)]
        public string? CPF { get; set; }

        // um cliente pode ter vários pedidos
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}