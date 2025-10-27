/*
regras
1h = 20 reais
carros grandes +20/h
carros pequenos +10/h

diárias (5h ou mais)
carros grandes +80
Carros pequenos +50

Tolerância na saída 5min

Valet (manobrista) 20% adicional no valor

Lavagem
carro grande 100 conto
carro pequeno 50

tempo de permanência nn pode passar de 12h

*/

string carro, valet, lavagem;
bool tamanhoCarro, fezValet, fezLavagem;
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
else if (minutos == 5)
{
    Console.WriteLine("Não ficou tempo o suficiente para pagar");
}
else
{

    if (tamanhoCarro = carro == "P") //Carro pequeno
    {

        if (horas <= 12 && horas >= 5) //se menor que 12, quer dizer que o carro ficou o tempo adequado
        {
            estacionamento = 50;

        }
        else estacionamento = (horas * 10) + 20; ;

    }
    else  //Carro grande
    {
        if (horas <= 12 && horas >= 5) //se menor que 12 e maior ou igual a 5, quer dizer que o carro ficou o tempo adequado da diária
        {
            estacionamento = 80;

        }
        // ficou menos que a diária
        else estacionamento = (horas * 20) + 20;

    }
    if (fezValet = valet == "S") //verificando se fez valet
    {
        
        valorValet = (estacionamento * 20) / 100;
    }
    else valorValet = 0;
 
        total = estacionamento + valorValet;

    Console.WriteLine($"Estacionamento..:       {estacionamento}");

    Console.WriteLine($"Valet...........:        R$ 0,00");

    Console.WriteLine($"Lavagem.........:        R$ 0,00\n");
    Console.WriteLine("--------------------------------");
    Console.WriteLine($"Total...........:       {total}");



}