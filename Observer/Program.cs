using Observer;

Console.WriteLine("Patrón Observer -> permite que un objeto (Subject) notifique automáticamente a múltiples observadores cuando su estado cambia.");
Console.WriteLine();
{
    var coleccion = new ColeccionDeMensajesDeBienvenida();

    IObserver loggerObserver = new LoggerObserver();
    coleccion.Suscribir(loggerObserver);

    IObserver contadorObserver = new ContadorObserver();
    coleccion.Suscribir(contadorObserver);

    IObserver auditoriaObserver = new AuditoriaObserver();
    coleccion.Suscribir(auditoriaObserver);

    IObserver uppercaseObserver = new UppercaseObserver();
    coleccion.Suscribir(uppercaseObserver);

    //Creo mensaje y disparo
    MensajeDeBienvenida mensajeDeBienvenida = new MensajeDeBienvenida("Bienvenido usuario A");
    coleccion.Agregar(mensajeDeBienvenida);
}

Console.WriteLine();
{
    var explicacionObserverMensaje = new ExplicacionObserverMensaje();
    Console.WriteLine(explicacionObserverMensaje.GetMessage());

    var notasAdicionales = new NotasAdicionales();
    Console.WriteLine(notasAdicionales.GetMessage());
}

Console.WriteLine("Fin del patrón Observer.");

