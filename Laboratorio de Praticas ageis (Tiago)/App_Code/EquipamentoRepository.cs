using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using emprestimoModel;

namespace Emprestimo
{
 
    public class EquipamentoRepository
    {
        private emprestimoEntities _ctxEmprestimo = new emprestimoEntities();

        public IQueryable<equipamento> FindAll()
        {
            return from equipamento in this._ctxEmprestimo.equipamentoes
                   orderby equipamento.NumeroSerie
                   select equipamento;
        }
    }
}