﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque
{
    [Table("produto", Schema = "public")]
    public class DtoProduct
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string unidade { get; set; }
        public decimal? preco { get; set; }
        public int? quantidade { get; set; }

    }
}
