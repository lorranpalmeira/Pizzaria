﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.Models;

namespace PizzariaAPI.Controllers
{

    [Route("api/[controller]")]
    public class PedidoController : Controller
    {
        #region MockDB
        public static List<Produto> _produtos = new List<Produto> {

            new Produto{IdProduto=01, NomeProduto="Pizza Calabresa", IdPizzaria=001, Valor=45.98},
            new Produto{IdProduto=02, NomeProduto="Pizza Mussarela", IdPizzaria=001, Valor=12.70},
            new Produto{IdProduto=03, NomeProduto="Pizza Portuguesa", IdPizzaria=001, Valor=25.20},
            new Produto{IdProduto=04, NomeProduto="Pizza HotDog", IdPizzaria=002, Valor=40.45},
            new Produto{IdProduto=05, NomeProduto="Pizza Mista", IdPizzaria=001, Valor=21.56},
            new Produto{IdProduto=06, NomeProduto="Pizza da Casa", IdPizzaria=001, Valor=30}
        };

        public static List<Pedido> _pedidos = new List<Pedido> {

            new Pedido{ IdPizzaria=001, Status=Status.ABERTO },
            new Pedido{ IdPizzaria=001, Status=Status.ABERTO},
            new Pedido{ IdPizzaria=001,  Status=Status.ABERTO},
            new Pedido{ IdPizzaria=002, Status=Status.ABERTO},
            new Pedido{IdPizzaria=001,  Status=Status.ENTREGUE},
            new Pedido{ IdPizzaria=001,  Status=Status.ABERTO}
        };

        #endregion


        [HttpPost]
        [Route("Listaprodutos")]
        public async Task<IActionResult> Listaprodutos([FromBody]Cliente cliente)
        {
            var produtos =_produtos.Where(x => x.IdPizzaria == cliente.IdPizzaria);

            return Ok(produtos);
        }

        [HttpPost]
        [Route("CriaPedido")]
        public async Task<IActionResult> CriaPedido([FromBody] Pedido pedido,
            ItensPedido itensPedido)
        {
            
            return Ok("Ok");
        }

        [HttpPost]
        [Route("PedidosEmAberto")]
        public async Task<IActionResult> PedidosEmAberto(Pizzaria pizzaria)
        {
            var pedidosEmAberto =_pedidos.Where(x => x.Status == Status.ABERTO 
            && x.IdPizzaria == pizzaria.IdPizzaria);

            return Ok(pedidosEmAberto);
        }

    }
}