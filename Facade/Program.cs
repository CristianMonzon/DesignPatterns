using Facade;

Console.WriteLine("Patrón Façade -> Simplifica el acceso a un subsistema complejo.");
Console.WriteLine();

{
    var fachada = new BienvenidaFacade();
    var mensaje = fachada.CrearBienvenida("Hola Usuario");

    Console.WriteLine("Mensaje generado por la fachada:");
    Console.WriteLine(mensaje.GetMessage());
}

Console.WriteLine();

{
    IMensajeDeBienvenida explicacion = new ExplicacionFacadeMensaje();
    Console.WriteLine(explicacion.GetMessage());
}

Console.WriteLine("Fin del patrón Façade.");
