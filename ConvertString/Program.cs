using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a palavra a ser invertida");
        string palavra = Console.ReadLine();
        string inverter = "";

        for (int i = palavra.Length - 1; i >= 0; i--)
        {
            inverter += palavra[i];
        }

        Console.WriteLine(inverter);
    }
}