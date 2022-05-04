using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ControleEstoque
{
    [Table("entrada", Schema = "public")]
    public class DtoEntrada
    {
        [Key]
        public int idproduto { get; internal set; }
        public int qteproduto { get; internal set; }
        public decimal vlrcustoproduto { get; internal set; }
        public decimal vlrtotalproduto { get; internal set; }
        public DateTime dtcompra { get; internal set; }
    }
}