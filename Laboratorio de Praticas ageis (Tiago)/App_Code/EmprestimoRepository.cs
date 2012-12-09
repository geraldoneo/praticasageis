using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using emprestimoModel;

namespace Emprestimo
{

    public class EmprestimoRepository
    {
        private emprestimoEntities _ctxEmprestimo = new emprestimoEntities();

        public IQueryable<emprestimo> FindAll()
        {
            return from emp in this._ctxEmprestimo.emprestimoes
                   join cli in this._ctxEmprestimo.clientes on
                   emp.IdCliente equals cli.IdCliente
                   join equip in this._ctxEmprestimo.equipamentoes on
                   emp.IdEquipamento equals equip.IdEquipamnto
                   select emp;
        }


        public IQueryable<emprestimo> FindAllByIdClient(int idClient)
        {
            return from emp in this._ctxEmprestimo.emprestimoes
                   join cli in this._ctxEmprestimo.clientes on
                   emp.IdCliente equals cli.IdCliente
                   join equip in this._ctxEmprestimo.equipamentoes on
                   emp.IdEquipamento equals equip.IdEquipamnto
                   where emp.IdCliente == idClient
                   select emp;
        }

        public void Add(emprestimo emprestimo)
        {
            this._ctxEmprestimo.AddToemprestimoes(emprestimo);
            this._ctxEmprestimo.SaveChanges();
        }
    }
}