// See https://aka.ms/new-console-template for more information
using Prototype;

Console.WriteLine("Prototype → Quiero clonar objetos ya configurados.");

Console.WriteLine("Quieres clonar objetos existentes");
Console.WriteLine("Evitas crear objetos desde cero");
Console.WriteLine("Quieres copiar configuraciones, mensajes o estructuras complejas");
Console.WriteLine("Quieres duplicar un objeto sin acoplarte a su clase concreta");
Console.WriteLine("Quieres duplicar un objeto sin acoplarte a su clase concreta");

Console.WriteLine("El cliente no debería saber: qué clase concreta está clonando, cómo se construye, qué propiedades internas tiene");
Console.WriteLine();

{
    
    var mensajeOriginal = new MensajeBienvenidaA();
    IMensajeDeBienvenida mensajeClonado = mensajeOriginal.Clonar();

    Console.WriteLine("Original A:");
    Console.WriteLine(mensajeOriginal.GetMessage());
    Console.WriteLine("Clonado A:");
    Console.WriteLine(mensajeClonado.GetMessage());
    Console.WriteLine();
}

{
    var mensajeOriginal = new MensajeBienvenidaB();
    IMensajeDeBienvenida mensajeClonado = mensajeOriginal.Clonar();

    Console.WriteLine("Original B:");
    Console.WriteLine(mensajeOriginal.GetMessage());
    
    Console.WriteLine("Clonado B:");
    Console.WriteLine(mensajeClonado.GetMessage());
    Console.WriteLine();

}

var explicacionPrototypeMensaje = new ExplicacionPrototypeMensaje();
Console.WriteLine(explicacionPrototypeMensaje.GetMessage());


Console.WriteLine();
Console.WriteLine("Fin del patrón Prototype.");

