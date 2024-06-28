// aula 146
Console.WriteLine("Polimorfismo com Sobrecarga\n");

Calcular calc = new Calcular();

Console.WriteLine($"30 + 40 = {calc.Somar(30, 40)}");

Console.WriteLine($"30 + 40+ 50 = {calc.Somar(30, 40, 50)}");

Console.ReadKey();

class Calcular
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }
    public int Somar(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
}