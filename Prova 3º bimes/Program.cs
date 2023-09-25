using Prova_3º_bimes;

List<FunciMedico> FM = new List<FunciMedico>();
while (true)
{
    Console.WriteLine($"\nOlá, qual tipo de funcionario desejas cadrastar? ");

    Console.WriteLine($"\n 1- Médico. ");
    Console.WriteLine($"\n 2- Administrador. ");
    int escolha = Convert.ToInt32( Console.ReadLine());

    if ( escolha == 1)
    {
        FunciMedico f = new FunciMedico("2304034",300, "Tecnico X área", "João Bezerra,", "005.456.232-56", 232323, new DateTime(1989, 5, 13), "Masculino", 7000);


    }
    else if ( escolha == 2) 
    {
        FuncAdm adm = new FuncAdm();
        Console.WriteLine(  );
    }
}