using Prova_3º_bimes;
using System.Globalization;
using System.Security.Cryptography;
using System.Threading.Channels;

while (true)
{
    Console.WriteLine($"\nOlá, qual tipo de funcionario desejas cadrastar? ");

    Console.WriteLine($"\n 1- Médico. ");
    Console.WriteLine($" 2- Administrador. ");
    Console.Write($" Opção: ");
    int escolha = Convert.ToInt32( Console.ReadLine());

    if (escolha == 1)
    {
        Console.WriteLine("\n 1- Fazer Cadratro ");
        Console.WriteLine(" 2 - Sair");
        Console.Write($" Opção: ");
        int es = Convert.ToInt32( Console.ReadLine());

        if ( es == 1)
        {
            List<FunciMedico> FM = new List<FunciMedico>();
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

            Console.WriteLine("\n Você recebera 20%: ");
            double sal = (salario * 0.20);

            Console.WriteLine($" Seu salario: {sal}");

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

        Console.WriteLine("\n 1- Fazer Cadratro ");
        Console.WriteLine(" 2 - Sair");
        Console.Write($" Opção: ");
        int esc = Convert.ToInt32(Console.ReadLine());
        if (esc == 1)
        {
            List<FuncAdm> FADM = new List<FuncAdm>();
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

            FuncAdm adm = new FuncAdm("Tecnico da área Asistencia de Software", nome2, cpf2, 323323, datanas2, gene2, 5000);

            Console.WriteLine("\n Voce recebe vale transporte? 1 - Sim e 2 - Não");
            int esco = Convert.ToInt32(Console.ReadLine());

            if (esco == 1)
            {
               
                double sal2 = (salario2 * 0.15);
                Console.WriteLine("Salario de : "+ sal2  );
            }
            else
            {
                Console.WriteLine( "nenhum valor adicional" );
            }
        }
        else if (escolha == 2)
        {
            break;
        }
    }
}