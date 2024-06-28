//aula 132
Console.WriteLine("Herança - Virtual e Override");

var gato = new Gato() { Nome = "bichano" };
gato.ExibeNome();

var cao = new Cachorro() { Nome = "pipoca" };
cao.ExibeNome();
