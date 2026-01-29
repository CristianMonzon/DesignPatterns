// See https://aka.ms/new-console-template for more information

using TemplateMethod;

Console.WriteLine("Patrón Template Method -> define el esqueleto de un algoritmo y permite redefinir pasos concretos.");
Console.WriteLine();

{
    Console.WriteLine("- Saludo formal:");
    IMensajeTemplate mensajeFormal = new MensajeBienvenidaFormal();
    Console.WriteLine(mensajeFormal.GenerarMensaje("Usuario A"));
    Console.WriteLine();

    Console.WriteLine("- Saludo informal:");
    IMensajeTemplate mensajeInformal = new MensajeBienvenidaInformal();
    Console.WriteLine(mensajeInformal.GenerarMensaje("Usuario A"));
}

Console.WriteLine();
{
    var explicacion = new ExplicacionTemplateMethodMensaje();
    Console.WriteLine(explicacion.GetMessage());

    var notas = new NotasAdicionales();
    Console.WriteLine(notas.GetMessage());

    var comparativaPatrones = new ComparativaPatrones();
    Console.WriteLine(comparativaPatrones.GetMessage());
    
}

Console.WriteLine("Fin del patrón Template Method.");

