﻿//aula 128
Console.WriteLine("Herança - comportamento modificadores de acesso\n");

ClasseDerivada classederivada = new();
classederivada.VerificaAcesso();

Console.ReadKey();

public class ClasseBase
{
    //Campos
    public int public_var = 1;
    protected int protected_var = 2;
    internal int internal_var = 3;
    private int private_var = 4;

    //Propriedades
    public int Private_var
    {
        get
        {
            return private_var;
        }
        set
        {
            private_var = value;
        }
    }

    //Métodos
    public void Public_Membro()
    {
        Console.WriteLine("ClasseBase - Método Public");
    }
    protected void Protected_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected");
        Console.WriteLine("Acesso ao campo private_var :  " + private_var);
    }
    internal void Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Internal");
    }
    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método protected internal");
    }
    private void Private_Membro()
    {
        Console.WriteLine("ClasseBase - Método private");
    }
}

public class ClasseDerivada : ClasseBase
{
    public void VerificaAcesso()
    {
        Public_Membro();
        Protected_Membro();
        Protected_Internal_Membro();
        Internal_Membro();
        //Private_Membro(); //Nâo pode ser acessado

        //Acessando o membro privado usando o modificador GET
        Console.WriteLine("\nAcesso ao campo private_var usando Propriedade (GET)");
        int soma = public_var + protected_var + internal_var + Private_var;
        Console.WriteLine("Total: " + soma);
    }
}
