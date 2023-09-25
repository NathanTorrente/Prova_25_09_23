using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3º_bimes
{
    internal class Funcionario
    {

        public string Nome {  get; set; }   
        public string Cpf { get; set;}
        public int Matricula { get; set;}   
        public DateTime DataNasci { get; set; }
        public string Sexo { get; set;} 
        public double Salalio { get; set;} 

        public Funcionario()
        {

        }
        public Funcionario(string nome, string cpf, int matricula, DateTime dataNasci, string sexo, double salalio)
        {   
            Nome = nome;
            Cpf = cpf;
            Matricula = matricula;
            DataNasci = dataNasci;
            Sexo = sexo;
            Salalio = salalio;
        }   
    }
}
