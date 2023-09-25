using Prova_3º_bimes;
using System.Globalization;
using System.Security.Cryptography;
using System.Threading.Channels;

while (true)
{
    Console.WriteLine($"\nOlá, qual tipo de funcionario desejas cadrastar? ");

    Console.WriteLine($"\n 1- Médico. ");
    Console.WriteLine($" 2- Administrador. ");
    int escolha = Convert.ToInt32( Console.ReadLine());

    if (escolha == 1)
    {
        Console.Write("\n 1- Fazer Cadratro ");
        Console.Write(" 2 - Sair");
        int es = Convert.ToInt32( Console.ReadLine());

        if ( es == 1)
        {
            List<FunciMedico> FM = new List<FunciMedico>();
            FunciMedico Md = new FunciMedico();

            Console.Write("\n Digite seu Nome: ");
            string nome = Convert.ToString(Console.ReadLine());
            Console.Write("\n Informe seu Gênero");
            string gene = Convert.ToString(Console.ReadLine());
            Console.Write(" Digite seu CPF: ");
            string cpf = Convert.ToString(Console.ReadLine());
            Console.Write(" Digite o Nº da sua Matricula: ");
            Console.Write(" Informe seu CRM ");
            string Crm = Convert.ToString(Console.ReadLine());
            int matri = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Informe sua data de nascimento: ");
            Console.Write("\n informe seu Salário ");
            double salario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nVocê recebera 20%: ");
            double sal = (salario * 0.20);

            Console.WriteLine($"\nSeu salario: {sal}");



            DateTime datanas = Convert.ToDateTime(Console.ReadLine());
            FunciMedico f = new FunciMedico(Crm, 300, "Tecnico área X", nome, cpf, 232323, datanas, gene, 7000);

            Md.Nome = nome;
            Md.Sexo = gene;
            Md.Cpf = cpf;
            Md.CRM = Crm;
            Md.Matricula = matri;
            Md.DataNasci = datanas;
            FM.Add(Md);

        }
        else if (es == 2)
        {
            break;
        }
 
    }
    else if ( escolha == 2) 
    {

        Console.Write("\n 1- Fazer Cadratro ");
        Console.Write(" 2 - Sair");
        int esc = Convert.ToInt32(Console.ReadLine());
        if (esc == 1)
        {
            List<FuncAdm> FADM = new List<FuncAdm>();
            FuncAdm FD = new FuncAdm();
            Console.Write("\n Digite seu Nome: ");
            string nome2 = Convert.ToString(Console.ReadLine());
            Console.Write("\n Informe seu Gênero");
            string gene2 = Convert.ToString(Console.ReadLine());
            Console.Write(" Digite seu CPF: ");
            string cpf2 = Convert.ToString(Console.ReadLine());
            Console.Write(" Digite o Nº da sua Matricula: ");
            Console.Write(" Informe seu CRM ");
            string Crm2 = Convert.ToString(Console.ReadLine());
            int matri2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Informe sua data de nascimento: ");
            DateTime datanas2 = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\n informe seu Salário ");
            double salario2 = Convert.ToInt32(Console.ReadLine());
            FuncAdm adm = new FuncAdm("Tecnico da área Asistencia de Software", nome2, cpf2, 323323, datanas2, gene2, 5000);

            Console.WriteLine("Voce recebe vale transporte? 1 e 2");
            
            Console.WriteLine("\nVocê recebera R$ 150: ");
            double sal2 = (salario2 * 0.15);
        }
        else if (escolha == 2)
        {
            break;
        }
      


    }
}