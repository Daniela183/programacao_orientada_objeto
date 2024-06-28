//aula 132


//Classe derivada
class Gato : Animal
{
    public override void ExibeNome() //Reescreve
    {
        Console.WriteLine($"\nEu sou um gato. Meu nome é: {Nome}");
    }
}
