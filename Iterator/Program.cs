using Iterator;

Console.WriteLine("Patrón Iterator -> permite recorrer una colección sin exponer su estructura interna.");

{
    IMensajeDeBienvenida mensajeA = new MensajeA();
    IMensajeDeBienvenida mensajeB = new MensajeB();

    var coleccion = new ColeccionDeMensajesDeBienvenida();
    coleccion.Agregar(mensajeA);
    coleccion.Agregar(mensajeB);
    IMensajeIterator<IMensajeDeBienvenida> iterador = coleccion.CrearIterador();

    int index = 1;
    while (iterador.HasNext())
    {
        var mensaje = iterador.Next();
        Console.WriteLine($"{index++} -> {mensaje.GetMessage()}");
    }
}
Console.WriteLine();
{
    IMensajeDeBienvenida mensaje1 = new ExplicacionIterator();
    IMensajeDeBienvenida mensaje2 = new NotasAdicionalesIterator();
    var coleccion = new ColeccionDeMensajesDeBienvenida();
    coleccion.Agregar(mensaje1);
    coleccion.Agregar(mensaje2);
    IMensajeIterator<IMensajeDeBienvenida> iterador = coleccion.CrearIterador();
    int index = 1;
    while (iterador.HasNext())
    {
        var mensaje = iterador.Next();
        Console.WriteLine($"{index++} -> {mensaje.GetMessage()}");
    }
}

Console.WriteLine("Fin patrón Interpreter");
