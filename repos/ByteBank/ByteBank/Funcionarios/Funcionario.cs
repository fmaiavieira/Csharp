﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        //propiedade
        public string Nome { get; set; }
        //propiedade
        public string CPF { get; private set; }
        //propiedade
        public double Salario { get; protected set; }

        //construtor
        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        //metodo
        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }

        //metodo
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        
    }
}
