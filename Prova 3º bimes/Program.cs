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

            Console.Write(" Se trabalhou horas extras digite a quantidade de horas: ");
            int hoex = Convert.ToInt32(Console.ReadLine());
            FunciMedico f = new FunciMedico(Crm, hoex, "Tecnico área X", nome, cpf, 232323, datanas, gene, 0);
            if (hoex > 0)
            {
                Console.WriteLine($"\n Voce recebeu R$ 100,00 de {hoex} horas extra: ");
                salario = (salario + 100);
            }
            else if (hoex <= 0)
            {
                Console.WriteLine("\n Nenhum valor...");
            }       
            Console.WriteLine(" Você recebu 20% de auxilio periculosidade: ");
            
             
             double sal = (salario + (salario * 20 / 100));
            Console.WriteLine($" Seu salario R$: {sal}");
            Md.Nome = nome;
            Md.Sexo = gene;
            Md.Cpf = cpf;
            Md.CRM = Crm;
            Md.Matricula = matri;
            Md.DataNasci = datanas;
            FM.Add(Md);

            foreach (FunciMedico Dados in FM)
            {
                Console.WriteLine($" Seus Dados: \n Nome: {Dados.Nome}\n Sexo: {Dados.Sexo}\n Cpf: {Dados.Cpf}\n CRM: {Dados.CRM}\n Matricula: {Dados.Matricula}\n Data:{Dados.DataNasci}");          
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

            FuncAdm adm = new FuncAdm("Tecnico da área Asistencia de Software", nome2, cpf2, 323323, datanas2, gene2, 0);

          
            Console.WriteLine(" Caso seja portador de vale transporte ou vale alimentação, digite 1 para --Transporte--, ou 2 para --Alimentação--");
            int es = Convert.ToInt32(Console.ReadLine());

            if (es == 1)
            {
                salario2 += 150;
                double sal2 = salario2 + (salario2 * 0.15);
                Console.WriteLine(" Salario de : "+ sal2  );
            }
            else if (es == 2) 
            {
                salario2 += (salario2 * 0.15);
                Console.WriteLine(" Salario de : " + salario2);
            }
            else
            {
                Console.WriteLine("nenhum valor adicional");
            }
            FD.Nome = nome2;
            FD.Sexo = gene2;
            FD.Salario = salario2;
            FD.DataNasci = datanas2;
            FD.Matricula = matri2;
            FD.Cpf = cpf2;

            FADM.Add(FD);

            foreach (FuncAdm Dados in FADM)
            {
                Console.WriteLine($" Seus Dados: \n Nome: {Dados.Nome}\n Salario: {Dados.Salario}\n Data nascimento: {Dados.DataNasci} \n Matricula: {Dados.Matricula}\n Cpf:{Dados.Cpf}");
            }
        }
        else if (escolha == 2)
        {
            break;
        }
    }
}