﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3º_bimes
{
    internal class FuncAdm:Funcionario
    {
        public string funcao { get; set; }

        public FuncAdm()
        {
        }
        public FuncAdm(string funcao, string nome, string cpf, int matricula, DateTime dataNasci, string sexo, double salario) 
        {          : base(nome, cpf, matricula, dataNasci, sexo);
            this.funcao = funcao;
        }
    }
}
