using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque
{
    class DtoSaidaList
    {
        public int idproduto { get; internal set; }
        public int qtevenda { get; internal set; }
        public decimal vlrcustoproduto { get; internal set; }
        public decimal vlrtotalvenda { get; internal set; }
        public DateTime dtvenda { get; internal set; }
    }
}
