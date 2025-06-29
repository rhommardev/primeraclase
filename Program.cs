// See https://aka.ms/new-console-template for more information
using System.Data;
using primeraclase.models;

/*
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "João";
pessoa1.Idade = 30;
pessoa1.Apresentar();

Console.WriteLine(System.Environment.Version);



//TIPOS DE DADOS 

int numero = 10;
string carro = "parati";
double preco = 10.50; // en el double no aparecera el cero final, no es aconcejable usar double para valores monetarios
// float preco = 10.50f; // el float es menos preciso que el double, no es aconsejable usarlo para valores monetarios
// decimal preco = 10.50m; // el decimal es el tipo de dato más adecuado para valores monetarios
decimal precoDecimal = 10.5m;
bool estaLigado = true;




Console.WriteLine(numero);
Console.WriteLine("este carro es da marca: " + carro);
Console.WriteLine("O preço do carro é: " + preco);
Console.WriteLine("O preço do carro é: " + precoDecimal);
Console.WriteLine("O carro está ligado? " + estaLigado);    



// Manipulação de datas
DateTime dataHora = DateTime.Now.AddDays(5).AddHours(2).AddMinutes(30);
Console.WriteLine(dataHora.ToString("dd/MM/yyyy HH:mm:ss"));
*/

TiposDeDatos carro = new TiposDeDatos();
carro.DatosDeUmCarro = "Parati";
carro.Marca = "Volkswagen";
carro.Ano = 2020;
carro.Preco = 50000.00;