//aula 140
Console.WriteLine("Interfaces\n");

IControle d = new Demo();
d.Nome = "Teste";
d.Desenhar();
d.Exibir();

Console.ReadKey();

interface IControle
{
    //public IControle() //Um campo de instância é um campo não estático q 
    //{}                //precisa de uma instância de um obj para ser acessado
    //int status;
    void Desenhar();
    string Nome { get; set; }
    public void Exibir()
    {
        Console.WriteLine("teste");
    }
}

interface IGrafico
{
    void Pintar();
}
public class Demo : IControle, IGrafico
{
    public string Nome { get; set; } = string.Empty;

    public void Desenhar()
    {
        Console.WriteLine("Desenhando"); ;
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando");
    }
}
