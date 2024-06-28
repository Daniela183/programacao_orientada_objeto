//aula 130
Console.WriteLine("Heranca e Objeto\n");

Nada nada = new();

Console.ReadKey();

public class Nada
{ }

public struct Struct1 //Não pode ter herança
{
}

public class Classe1
{
}

public class Classe2
{
}

public class ClasseDerivada : Classe1 // Classe2 não suporta herança multipla, mais de uma classe base 
{
}
