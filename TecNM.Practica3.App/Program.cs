using System;
using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Managers;
using TecNM.Practica3.Core.Services;

namespace TecNM.Practica3.App;

public static class Program{
    public static void Main(string[] args){
        float salario = 0;

        System.Console.WriteLine("Introduce tu salario: ");
        Single.TryParse(System.Console.ReadLine(), out salario);

        var person = new Person { salario = salario };
        var service = new ISRService();
        var manager = new ISRManager(service);

        ISR isr = manager.GetSalario(person);

        System.Console.WriteLine($"El resultado de tu ISR es:  {isr.isrFinal}");
    }
}
