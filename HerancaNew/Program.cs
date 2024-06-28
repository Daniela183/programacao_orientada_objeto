//aula 131
Console.WriteLine("Herança - modificador new (override)\n");

Aluno aluno = new();
aluno.Nome = "Maria";
aluno.Curso = "Química";
Console.WriteLine(aluno.Saudacao());

Console.ReadKey();

class Pessoa //Base
{
    public string? Nome { get; set; }

    public string Saudacao() => $"Oi, Eu sou o(a) {Nome}"; //Vai deixar de usar da classe base pois é o mesmo nome
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }

    public new string Saudacao() //Passando o new, você fala que quer ocultar
        => $"Oi, Eu sou o(a) {Nome} do curso de: {Curso}."; //Vai usar esse método da classe derivada
}