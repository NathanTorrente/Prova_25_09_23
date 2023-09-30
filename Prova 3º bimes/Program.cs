using Prova_3º_bimes;
using System.Globalization;
using System.Security.Cryptography;
using System.Threading.Channels;
List<FunciMedico> FM = new List<FunciMedico>();
List<FuncAdm> FADM = new List<FuncAdm>();
while (true)
{
    Console.WriteLine($"\nOlá, qual tipo de funcionario desejas cadrastar? ");

    Console.WriteLine($"\n 1- Médico. ");
    Console.WriteLine($" 2- Administrador. ");
  
    Console.Write($" Opção: ");
    int escolha = Convert.ToInt32( Console.ReadLine());
    Console.Clear();
    if (escolha == 1)
    {
        Console.WriteLine("\n 1- Fazer Cadratro ");
        Console.WriteLine(" 2 - Sair");
        Console.Write($" Opção: ");
        int es = Convert.ToInt32( Console.ReadLine());
        Console.Clear();

        if ( es == 1)
        {
       
            FunciMedico Md = new FunciMedico();

            Console.Write("\n Digite seu Nome: ");
            string nome = Convert.ToString(Console.ReadLine());

            Console.Write(" Informe seu Gênero: ");
            string gene = Convert.ToString(Console.ReadLine());

            Console.Write(" Digite seu CPF: ");
            string cpf = Convert.ToString(Console.ReadLine());

            Console.Write(" Informe seu CRM: ");
            string Crm = Convert.ToString(Console.ReadLine());

            Console.Write(" Digite o Nº da sua Matricula: ");
            int matri = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Informe sua data de nascimento: ");
            DateTime datanas = Convert.ToDateTime(Console.ReadLine());

            Console.Write(" informe seu Salário: ");
            double salario = Convert.ToInt32(Console.ReadLine());

            FunciMedico f = new FunciMedico();
       
 
            Md.Nome = nome;
            Md.Sexo = gene;
            Md.Cpf = cpf;
            Md.CRM = Crm;
            Md.Matricula = matri;
            Md.DataNasci = datanas;
            FM.Add(Md);

            foreach (FunciMedico Dados in FM)
            {
               
                Console.WriteLine($" Seus Dados: \n Salario: {f.Salario}\n Nome: {Dados.Nome}\n Sexo: {Dados.Sexo}\n Cpf: {Dados.Cpf}\n CRM: {Dados.CRM}\n Matricula: {Dados.Matricula}\n Data:{Dados.DataNasci}");          
            }
        }
        else if (es == 2)
        {
            break;
        }
    }
    else if ( escolha == 2) 
    {
        Console.WriteLine("\n 1- Fazer Cadratro ");
        Console.WriteLine(" 2 - Sair");
        Console.Write($" Opção: ");
        int esc = Convert.ToInt32(Console.ReadLine());
        if (esc == 1)
        {
          
            FuncAdm FD = new FuncAdm();

            Console.Write("\n Digite seu Nome: ");
            string nome2 = Convert.ToString(Console.ReadLine());

            Console.Write(" Informe seu Gênero: ");
            string gene2 = Convert.ToString(Console.ReadLine());

            Console.Write(" Digite seu CPF: ");
            string cpf2 = Convert.ToString(Console.ReadLine());

            Console.Write(" Digite o Nº da sua Matricula: ");
            int matri2 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Informe seu CRM: ");
            string Crm2 = Convert.ToString(Console.ReadLine());
            
            Console.Write(" Informe sua data de nascimento: ");
            DateTime datanas2 = Convert.ToDateTime(Console.ReadLine());

            Console.Write("\n informe seu Salário: ");
            double salario2 = Convert.ToInt32(Console.ReadLine());

            FuncAdm adm = new FuncAdm();

            FD.Nome = nome2;
            FD.Sexo = gene2;
            FD.Salario = salario2;
            FD.DataNasci = datanas2;
            FD.Matricula = matri2;
            FD.Cpf = cpf2;

            FADM.Add(FD);
       

            foreach (FuncAdm Dados in FADM)
            {
                
                Console.WriteLine($" Seus Dados: \n Nome: {Dados.Nome}\n Salario: {FD.Salario}\n Data nascimento: {Dados.DataNasci} \n Matricula: {Dados.Matricula}\n Cpf:{Dados.Cpf}");
            }
        }
        else if (escolha == 2)
        {
            break;
        }
    }
}