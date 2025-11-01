string carro, valet, lavagem;
decimal valorValet, estacionamento, valorLavagem, total, minutos, horas;

//Pegando informações sobre quem estacionou
Console.Write($"Tamanho do veículo (P/G).....: ");
carro = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();


Console.Write($"Tempo de permanência (min)...: ");
minutos = Convert.ToDecimal(Console.ReadLine()!);
horas = Math.Floor(minutos/60);

Console.Write($"Serviço de valet (S/N).......: ");
valet = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

Console.Write($"Serviço de lavagem (S/N).....: ");
lavagem = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();


if (horas > 12) // se for maior que 12h, não ficou o tempo adequado
{
    Console.WriteLine("O veículo não pode ficar estacionado mais que 12 horas no local.");
}
else if (minutos <= 5)
{
    Console.WriteLine("Não ficou tempo o suficiente para pagar");
}
else
{
    
    if (carro == "P") //Carro pequeno
    {

        if (horas >= 5) //deu o tempo da diária, trava em 50
        {
            estacionamento = 50;

        }
        else estacionamento = ((horas-1) * 10) + 20;

    }
    else  //Carro grande
    {
        if (horas >= 5) //deu o tempo da diária, trava em 80
        {
            estacionamento = 80;

        }
        // ficou menos que a diária
        else estacionamento = ((horas-1) * 20) + 20;

    }


    if (valet == "S") //verificando se fez valet
    {

        valorValet = (estacionamento * 20) / 100;
    }
    else valorValet = 0;

    if (lavagem == "S") //fez lavagem?
    {
        valorLavagem = 100; //paga 100
    }
    else valorLavagem = 0;


    total = estacionamento + valorValet + valorLavagem;

    Console.WriteLine($"Estacionamento..:       R$ {estacionamento:N2}  ");

    Console.WriteLine($"Valet...........:       R$ {valorValet:N2}  ");

    Console.WriteLine($"Lavagem.........:   R$ {valorLavagem:N2}\n  ");
    Console.WriteLine("--------------------------------");
    Console.WriteLine($"Total...........:       R$ {total:N2}  ");
}