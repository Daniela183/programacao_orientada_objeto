//aula 132


//Classe base
class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibeNome() //Subscrito
    {
        Console.WriteLine($"\nMeu nome é: {Nome}");
    }
}
