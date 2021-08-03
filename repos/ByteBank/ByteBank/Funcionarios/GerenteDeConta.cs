using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class GerenteDeConta : Funcionario
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
        }
        
        //metodo
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        //metodo
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
