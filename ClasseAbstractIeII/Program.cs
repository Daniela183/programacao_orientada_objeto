//aula 138/139
using ClasseAbstractIeII;

Console.WriteLine("Modificador Abstract I e II\n");

Quadrado q = new Quadrado();
Console.WriteLine(q.Descricao());

Console.Write("\nInforme a cor da figura: ");
q.Cor = Console.ReadLine();

Console.Write("\nInforme o valor do quadrado (m): ");
q.Lado = Convert.ToInt32(Console.ReadLine());

q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine($"\nA área do quadrado é: {q.Area} m2");
Console.WriteLine($"\nO perímetro do quadrado é: {q.Perimetro} m ");
Console.WriteLine($"\nO quadrado tem a cor: {q.Cor}");
Console.ReadKey();