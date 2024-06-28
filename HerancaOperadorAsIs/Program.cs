//aula 137
using HerancaOperadorAsIs;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Operadores As e Is\n");

//Fazendo a conversão explícita (casting) sem usar o operador as

Object carroObj = new Carro();

try
{
var x = (string)carroObj; //System.InvalidCastException;
}
catch (Exception ex)
{
Console.WriteLine("A conversão falhou\n");
Console.WriteLine(ex.Message);
}

//Fazendo a conversão usando o operador as

Object carroObj1 = new Carro();

var y = carroObj1 as string;  //Avalia y como null

if (y != null)
{
Console.WriteLine("\nconverteu obj para string");
}
else
{
Console.WriteLine("\ny é null\n");
}

//Fazendo o downcasting usando o operador as

Circulo circulo1 = new Circulo();
Forma forma1 = circulo1;    //Upcasting

//Circulo c = (Circulo)forma;
Circulo c = forma1 as Circulo;  //Downcasting

if (c != null)
{
c.PintarCirculo();
}
else
{
Console.WriteLine("\nOperação de downcasting é inválida");
}



Circulo circulo = new Circulo();
Forma forma = circulo;

if (forma is Circulo)   //Verifica se o downcast é possivel
{
Console.WriteLine("\nConverteu Forma para Circulo\n");

//((Circulo)forma).PintarCirculo();
var tipo = forma as Circulo;
tipo?.PintarCirculo();
}
else
{
Console.WriteLine("\nOperação de downcasting não é possível");
}

Console.ReadKey();
class Carro
{ }


