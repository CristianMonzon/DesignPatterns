using Proxy;

Console.WriteLine("Patrón Proxy -> Controla el acceso a un objeto real.");
Console.WriteLine();

{
    IMensajeDeBienvenida mensaje = new MensajeProxy("Usuario A");

    Console.WriteLine("Primera llamada (crea el objeto real):");
    Console.WriteLine(mensaje.GetMessage());

    Console.WriteLine();

    Console.WriteLine("Segunda llamada (usa el objeto real ya creado):");
    Console.WriteLine(mensaje.GetMessage());

    Console.WriteLine();

    Console.WriteLine("Proxy con usuario inválido (no crea el objeto real):");
    IMensajeDeBienvenida mensajeInvalido = new MensajeProxy(null);
    Console.WriteLine(mensajeInvalido.GetMessage());

}
Console.WriteLine();
{
    var explicacion = new ExplicacionProxyMensaje();
    Console.WriteLine(explicacion.GetMessage());
}
{ 
    var notasAdicionales = new NotasAdicionales();
    Console.WriteLine(notasAdicionales.GetMessage());

}

Console.WriteLine("Fin del patrón Proxy.");