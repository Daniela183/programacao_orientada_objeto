//aula 129
Console.WriteLine("Herança - Construtores\n");

Aluno aluno1 = new();
Aluno aluno2 = new("José");

Console.ReadKey();

//Base
class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Primeiro chama a classe base sem param, depois chama a classe derivada sem param\n");

        Console.WriteLine("Construtor da classe Pessoa");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("Primeiro chama a classe base com param, depois chama a classe derivada com param\n");
        Console.WriteLine("Construtor da classe Pessoa com parâmetro");
    }
}

//Derivada
class Aluno : Pessoa
{
    public Aluno() : base() //Sem param
    {

        Console.WriteLine("Construtor da classe Aluno\n");
    }
    public Aluno(string nome) : base(nome) //Com param
    {
        Console.WriteLine("Construtor da classe Aluno com parâmetro");
    }
}