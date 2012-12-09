using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using emprestimoModel;

namespace Emprestimo
{
 
    public class ClientRepository
    {
        private emprestimoEntities _ctxEmprestimo = new emprestimoEntities();

        public IQueryable<cliente> FindAll()
        {
            return from cliente in this._ctxEmprestimo.clientes
                   orderby cliente.Nome
                   select cliente;
        }
    }
}