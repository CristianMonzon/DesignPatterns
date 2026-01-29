using Strategy;

Console.WriteLine("Patrón Strategy -> permite cambiar un algoritmo por otro en tiempo de ejecución, sin modificar el código del cliente.");
Console.WriteLine();

{
    IStrategySaludo estrategiaSaludoFormal = new SaludoFormal();
    
    MensajeDeBienvenidaConStrategy mensaje = new MensajeDeBienvenidaConStrategy(estrategiaSaludoFormal);
    Console.WriteLine(mensaje.GetMessage("Usuario A"));

    //Cambio la estrategia en modo de ejecución
    IStrategySaludo estrategiaSaludoInformal = new SaludoInformal();    
    mensaje.CambiarStrategy(estrategiaSaludoInformal); 
    Console.WriteLine(mensaje.GetMessage("Usuario A"));

    //Cambio la estrategia en modo de ejecución
    IStrategySaludo estrategiaSaludoNavidad = new SaludoNavidad();
    mensaje.CambiarStrategy(estrategiaSaludoNavidad);
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
