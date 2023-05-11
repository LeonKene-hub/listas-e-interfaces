using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto_interface
{
    public class Carrinho : ICarrinho
    {
        public float Valor { get; set; }

        List<Produto> carrinho = new List<Produto>();

        //Implementar a logica para cada metodo
        public void Adicionar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Listar()
        {
            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine($"Codigo: {p.Codigo} - Nome: {p.Nome} - Preco: {p.Preco:c}");
                }
            }
            else
            {
                Console.WriteLine($"Vazio....");
                
            }
        }

        public void Atualizar(int codigo, Produto produto)
        {
            carrinho.Find(x => x.Codigo == codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == codigo).Preco = produto.Preco;
        }

        public void Remover(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}