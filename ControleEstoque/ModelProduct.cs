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
    }
}
