using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque
{
    [Table("saida", Schema = "public")]
    public class DtoSaida
    {
        [Key]
        public int idproduto { get; internal set; }
        public int qtevenda { get; internal set; }
        public decimal vlrcustoproduto { get; internal set; }
        public decimal vlrtotalvenda { get; internal set; }
        public DateTime dtvenda { get; internal set; }
    }
}
