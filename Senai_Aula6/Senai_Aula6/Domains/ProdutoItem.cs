﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senai_Aula6.Domains
{
    public class ProdutoItem : BaseDomain
    {

        public Guid IdPedido { get; set; }
        [ForeignKey("IdPedido")]
        public Pedido Pedido { get; set; }

        public Guid IdProduto { get; set; }
        [ForeignKey("IdProduto")]
        public Produto Produto { get; set; }

        [Required]
        public int Quantidade { get; set; }

    }
}
