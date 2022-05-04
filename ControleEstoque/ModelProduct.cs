using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque
{
    internal class ModelProduct
    {
        internal void SetProduto(DtoProduct p)
        {
            Context db = new Context();
            db.produto.Add(p);
            db.SaveChanges();

        }

        internal DtoProduct GetProduto(int id)
        {
            Context db = new Context();
            DtoProduct produto = db.produto.FirstOrDefault(o => o.id == id);

            return produto;
        }

        public List<DtoProductList> GetProdutos()
        {
            Context db = new Context();

            List<DtoProductList> produtos = (from p in db.produto
                                              select new DtoProductList
                                              {
                                                  id = p.id,
                                                  nome = p.nome,
                                                  unidade = p.unidade,
                                                  quantidade = p.quantidade,
                                                  preco = p.preco
                                              }).ToList();
            return produtos;
        }

        public List<DtoProductList> ListProdutosNome(string text)
        {
            Context db = new Context();
            List<DtoProductList> result = (from a in db.produto
                                        where a.nome.Contains(text)
                                        select new DtoProductList
                                        {
                                            id = a.id,
                                            nome = a.nome,
                                            quantidade = a.quantidade
                                        }).ToList();

            return result;
        }


        internal void EditarProduto(DtoProduct p)
        {
            Context db = new Context();
            DtoProduct produto = db.produto.FirstOrDefault(o => o.id == p.id);
            produto.nome = p.nome;
            produto.unidade = p.unidade;
            produto.quantidade = p.quantidade;
            produto.preco = p.preco;
            db.SaveChanges();
        }

        internal void DeletarProduto(int id)
        {
            Context db = new Context();
            DtoProduct produto = db.produto.FirstOrDefault(o => o.id == id);
            db.produto.Remove(produto);
            db.SaveChanges();
        }

        internal void SetEntradaProduto(DtoEntrada entrada)
        {
            Context db = new Context();
            db.entrada.Add(entrada);
            db.SaveChanges();

        }

        public List<DtoEntradaList> ListProdutosEntrada()
        {
            Context db = new Context();

            List<DtoEntradaList> result = (from e in db.entrada
                                           select new DtoEntradaList
                                           {
                                              idproduto = e.idproduto,
                                              qteproduto = e.qteproduto,
                                              dtcompra = e.dtcompra,
                                              vlrcustoproduto = e.vlrcustoproduto,
                                              vlrtotalproduto = e.vlrtotalproduto 
                                           }).ToList();

            return result;
        }

        internal DtoEntrada GetEntrada(int id)
        {
            Context db = new Context();
            DtoEntrada entrada = db.entrada.FirstOrDefault(o => o.idproduto == id);

            return entrada;
        }

        internal void EditarEntradaVenda(DtoEntrada e)
        {
            Context db = new Context();
            DtoEntrada entrada = db.entrada.FirstOrDefault(o => o.idproduto == o.idproduto);
            entrada.qteproduto = e.qteproduto;
           
            db.SaveChanges();
        }

        internal void SetSaidaProduto(DtoSaida saida)
        {
            Context db = new Context();
            db.saida.Add(saida);
            db.SaveChanges();

        }

        public List<DtoSaidaList> ListProdutosSaida()
        {
            Context db = new Context();

            List<DtoSaidaList> result = (from e in db.saida
                                           select new DtoSaidaList
                                           {
                                               idproduto = e.idproduto,
                                               qtevenda = e.qtevenda,
                                               dtvenda = e.dtvenda,
                                               vlrcustoproduto = e.vlrcustoproduto,
                                               vlrtotalvenda = e.vlrtotalvenda
                                           }).ToList();

            return result;
        }

    }
}
