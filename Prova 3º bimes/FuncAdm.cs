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
        public FuncAdm(string funcao, string nome2, string cpf, int matricula, DateTime dataNasci, string sexo, double salario) 
                  : base(nome2, cpf, matricula, dataNasci, sexo, salario)
        {
            this.funcao = funcao;
        
        }
        public void Aumento()
        {

            double valeTransporte = 150;
            double valeAlimentcao = Salario + 0.15;
            Salario = valeAlimentcao + valeTransporte;
            Console.WriteLine($"Seu salario é: {Salario}");
           
        }
    }
}
