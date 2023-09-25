using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3º_bimes
{
    internal class FunciMedico: Funcionario
    {
        public string CRM { get; set; }
        public double HoraExt { get; set; }
        public string especialidade { get; set; }   

        public FunciMedico()
        {

        }
        public FunciMedico(string crm, double horaExt, string especialidade, string nome, string cpf, int matricula, DateTime dataNasci, string sexo, double salario)
        {                 :base(nome, cpf, matricula, dataNasci, sexo, salario);

            CRM = crm;
            HoraExt = horaExt;
            this.especialidade = especialidade;
        }
    }
}
