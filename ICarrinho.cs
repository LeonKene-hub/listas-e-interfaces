using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto_interface
{
    public interface ICarrinho
    {
        //definir quais os metodos deverao ser implementados
        //na class que herdar desta interface

        //CRUD : Create / Read / Update / Delete

        //------------- Create -------------
        void Adicionar(Produto produto);

        //------------- Read -------------
        void Listar();

        //------------- Update -------------
        void Atualizar(int codigo, Produto produto);

        //------------- Delete -------------
        void Remover(Produto produto);
    }
}