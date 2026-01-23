// See https://aka.ms/new-console-template for more information
using Composite;

Console.WriteLine("Composite -> Permite tratar objetos individuales y compuestos de la misma manera.");
Console.WriteLine("Un objeto simple (MensajeSimple) y un objeto compuesto (MensajeCompuesto) implementan la misma interfaz.");
Console.WriteLine("El cliente no necesita saber si está trabajando con un mensaje o con un grupo de mensajes.");
Console.WriteLine("Esto permite construir estructuras jerárquicas (árboles) sin cambiar el código cliente.");
Console.WriteLine();

{
    IMensajeDeBienvenida mensaje1 = new MensajeSimple("Hola usuario");
    IMensajeDeBienvenida mensaje2 = new MensajeSimple("Bienvenido al sistema");

    //Esta es la parte clave del patrón Composite
    MensajeCompuesto mensajeCompuesto = new MensajeCompuesto();

    mensajeCompuesto.Add(mensaje1);
    mensajeCompuesto.Add(mensaje2);
    Console.WriteLine(mensajeCompuesto.GetMessage());
}

Console.WriteLine();

{
    var explicacion = new ExplicacionCompositeMensaje();
    Console.WriteLine(explicacion.GetMessage());
}

Console.WriteLine("Fin del patrón Composite.");