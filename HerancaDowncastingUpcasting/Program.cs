//aula 138
using HerancaDowncastingUpcasting;

Console.WriteLine("Downcasting e Upcasting\n");

Circulo circulo = new Circulo(20, 20);
Forma f = circulo;    //Upcasting

Circulo c = (Circulo)f;   //Downcasting

c.Desenhar();
c.PintarCirculo();

Console.WriteLine(c == f);
Console.WriteLine(c == circulo);

Console.ReadKey();