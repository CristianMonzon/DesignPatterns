using Strategy;

Console.WriteLine("Patrón Strategy -> permite cambiar un algoritmo por otro en tiempo de ejecución, sin modificar el código del cliente.");
Console.WriteLine();

{
    IStrategySaludo saludoFormal = new SaludoFormal();
    
    MensajeDeBienvenidaConStrategy mensaje = new MensajeDeBienvenidaConStrategy(saludoFormal);
    Console.WriteLine(mensaje.GetMessage("Usuario A"));

    //Cambio la estrategia en modo de ejecución
    var saludoInformal = new SaludoInformal();    
    mensaje.CambiarStrategy(saludoInformal); 
    Console.WriteLine(mensaje.GetMessage("Usuario A"));

    //Cambio la estrategia en modo de ejecución
    var saludoNavidad = new SaludoNavidad();
    mensaje.CambiarStrategy(saludoNavidad);
    Console.WriteLine(mensaje.GetMessage("Usuario A"));
}

Console.WriteLine();
{
    var explicacionStrategyMensaje = new ExplicacionStrategyMensaje();
    Console.WriteLine(explicacionStrategyMensaje.GetMessage());

    var notasAdicionales = new NotasAdicionales();
    Console.WriteLine(notasAdicionales.GetMessage());
}

Console.WriteLine("Fin del patrón Strategy.");
