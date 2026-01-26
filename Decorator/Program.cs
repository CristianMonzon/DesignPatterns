// See https://aka.ms/new-console-template for more information
using Decorator;

Console.WriteLine("Decorator -> Permite añadir responsabilidades adicionales a un objeto de forma dinámica, sin modificar su clase original.");
Console.WriteLine("Un decorador envuelve un objeto y añade comportamiento antes o después de delegar la llamada.");
Console.WriteLine("Es una alternativa flexible a la herencia cuando quieres extender comportamiento sin crear una explosión de subclases.");

Console.WriteLine();

{
    IMensajeDeBienvenida mensajeBase = new Mensajes("hola usuario");
    Console.WriteLine($"mensaje base: {mensajeBase.GetMessage()}");
    
    IMensajeDeBienvenida mensajeConFecha = new DecoradorConFecha(mensajeBase);
    Console.WriteLine($"mensaje conFecha: {mensajeConFecha.GetMessage()}");

    IMensajeDeBienvenida mensajeEnMayusculas = new DecoradorMayusculas(mensajeConFecha);
    Console.WriteLine($"mensaje mensajeEnMayusculas: {mensajeEnMayusculas.GetMessage()}");

    IMensajeDeBienvenida mensajeConPrefijo = new DecoradorConPrefijo(mensajeEnMayusculas);
    Console.WriteLine($"mensaje con prefijo: {mensajeConPrefijo.GetMessage()}");

    IMensajeDeBienvenida mensajeConDobleFecha = new DecoradorConFecha(mensajeConPrefijo);
    Console.WriteLine($"mensaje con doble fecha: {mensajeConDobleFecha.GetMessage()}");

    Console.WriteLine();

    var explicacionDecoratorMensaje = new ExplicacionDecoratorMensaje();
    Console.WriteLine(explicacionDecoratorMensaje.GetMessage());
    
    var notasAdicionales = new NotasAdicionales();
    Console.WriteLine(notasAdicionales.GetMessage());

}

Console.WriteLine("Fin del patrón Decorator.");