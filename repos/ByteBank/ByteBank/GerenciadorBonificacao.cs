using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class GerenciadorBonificacao
    {
        //campo
        private double _totalBonificacao;

        //metodo
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        //metodo
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
