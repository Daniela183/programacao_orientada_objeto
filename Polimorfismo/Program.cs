//aula 145 - 146
using Polimorfismo;

Console.WriteLine("Polimorfismo - exemplo\n");

var figuras = new List<Figura> //polimorfismo
{
    new Triangulo(),
    new Circulo()
};

foreach (var figura in figuras)
{
    figura.Desenhar();
}


Console.ReadKey();
