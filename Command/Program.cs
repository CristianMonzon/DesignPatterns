using Command;

Console.WriteLine("Patrón Command -> Ejecutar acciones encapsuladas como objetos");
{
    var receiver = new MensajeReceiver();
    var invoker = new MensajeInvoker();

    var enviarMensaje = new EnviarMensajeCommand(receiver, "Usuario A");
    invoker.SetCommand(enviarMensaje);
    invoker.Ejecutar();
    invoker.Deshacer();
    Console.WriteLine();

    var enviarMensaje2 = new EnviarMensajeCommand(receiver, "Usuario B");
    invoker.SetCommand(enviarMensaje2);
    invoker.Ejecutar();
    invoker.Deshacer();

    Console.WriteLine();
}

{
    var explicacionCommand = new ExplicacionCommand();
    Console.WriteLine(explicacionCommand.GetMessage());
}
{
    var notasAdicionales = new NotasAdicionales();
    Console.WriteLine(notasAdicionales.GetMessage());
}

Console.WriteLine("Fin patrón Command");

