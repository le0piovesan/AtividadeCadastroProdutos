namespace ControleEstoque
{
    public class DtoProductList
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string unidade { get; set; }
        public int? quantidade { get; set; }
        public decimal? preco { get; set; }
    }
}