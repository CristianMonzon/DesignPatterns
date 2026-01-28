using State;

Console.WriteLine("Patrón State ->  permite que un objeto cambie su comportamiento cuando cambia su estado interno.");
Console.WriteLine();

{
    IEstadoMensaje estadoInicial = new EstadoInicial();
    IEstadoMensaje estadoEnProceso = new EstadoEnProceso();
    IEstadoMensaje estadoFinalizado = new EstadoFinalizado();
    IEstadoMensaje estadoError = new EstadoError();

    MensajeDeBienvenidaConEstado mensaje = new MensajeDeBienvenidaConEstado(estadoInicial);

    Console.WriteLine(mensaje.GetMessage());

    mensaje.CambiarEstado(estadoEnProceso);
    Console.WriteLine(mensaje.GetMessage());

    mensaje.CambiarEstado(estadoFinalizado);
    Console.WriteLine(mensaje.GetMessage());

    Console.WriteLine();

    Console.WriteLine("Ejemplo didáctico: mostramos el estado de error");
    mensaje.CambiarEstado(estadoError);
    Console.WriteLine(mensaje.GetMessage());
}

Console.WriteLine();

{
    var explicacionStateMensaje = new ExplicacionStateMensaje();
    Console.WriteLine(explicacionStateMensaje.GetMessage());

    var notasAdicionales = new NotasAdicionales();
    Console.WriteLine(notasAdicionales.GetMessage());
}

Console.WriteLine("Fin del patrón State.");