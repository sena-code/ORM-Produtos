using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Aula6.Domains
{
    public class ProdutoItem : BaseDomain
    {
        
        [ForeignKey("Produto")]
        public Guid IdPedido { get; set; }
        public Pedido Pedidos { get; set; }

        [ForeignKey("Pedido")]
        public Guid IdProduto { get; set; }
        public Produto Produtos { get; set; }
    }
}
