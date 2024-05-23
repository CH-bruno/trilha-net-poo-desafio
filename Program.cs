using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Instanciando um Nokia
        Smartphone meuNokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 32);
        meuNokia.Ligar();
        meuNokia.ReceberLigacao();
        meuNokia.InstalarAplicativo("Snake");

        Console.WriteLine("\n");

        // Instanciando um iPhone
        Smartphone meuIphone = new Iphone("987654321", "iPhone 12", "987654321098765", 128);
        meuIphone.Ligar();
        meuIphone.ReceberLigacao();
        meuIphone.InstalarAplicativo("Instagram");

   
    }
}
