namespace ControleEstoque.API.DTOs
{
    public class CriarPedidoDTO
    {
        public int ClienteId { get; set; }

        public List<CriarItemPedidoDTO> Itens { get; set; } 
    }

    public class CriarItemPedidoDTO
    {
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}
