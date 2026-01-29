using Mediator;

Console.WriteLine("Patrón Mediator -> Define un objeto que encapsula la manera en la que otros objetos interactúan entre sí.");
Console.WriteLine();

{
    CentroDeCoordinacionMediator mediator = new CentroDeCoordinacionMediator();

    mediator.Generador = new GeneradorDeMensajes(mediator);
    mediator.Logger = new LoggerDeBienvenida(mediator);
    mediator.Notificador = new NotificadorDeUsuarios(mediator);
    mediator.Validador = new ValidadorDeUsuario(mediator);

    var usuario = new Usuario("Usuario A");

    RegistroDeUsuarios registro = new RegistroDeUsuarios(mediator);
    registro.Informar(usuario);
}

Console.WriteLine();

{
    var explicacionMediatorMensaje = new ExplicacionMediatorMensaje();
    Console.WriteLine(explicacionMediatorMensaje.GetMessage());
}

Console.WriteLine();
Console.WriteLine("Fin del patrón Mediator.");
