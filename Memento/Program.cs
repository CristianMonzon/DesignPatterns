using Memento;

Console.WriteLine("Patrón Memento -> permite guardar y restaurar el estado interno de un objeto sin violar su encapsulación.");
Console.WriteLine();
{

    var editor = new EditorDeMensajes();
    var historial = new HistorialDeMensajes();

    editor.Escribir("{Estado 1} - Hola Usuario A");
    MensajeMemento mensajeMemento = editor.CrearMemento();
    historial.Guardar(mensajeMemento);

    editor.Escribir("{Estado 2} - Hola Usuario A, bienvenido al sistema");
    MensajeMemento mensajeMemento_2 = editor.CrearMemento();
    historial.Guardar(mensajeMemento_2);

    editor.Escribir("{Estado 3} Hola Usuario A, bienvenido al nuevo estado del sistema");
    
    Console.WriteLine(">> Deshacer");
    MensajeMemento? estadoAnterior = historial.Deshacer();
    if (estadoAnterior != null) { 
        editor.Restaurar(estadoAnterior);
    }

    Console.WriteLine(">>Deshacer otra vez");
    estadoAnterior = historial.Deshacer();
    if (estadoAnterior != null)
    {
        editor.Restaurar(estadoAnterior);
    }

    Console.WriteLine(">>Deshacer otra vez");
    estadoAnterior = historial.Deshacer();
    if (estadoAnterior != null)
    {
        editor.Restaurar(estadoAnterior);
    }

    Console.WriteLine();
    {
        var explicacionMementoMensaje = new ExplicacionMementoMensaje();
        Console.WriteLine(explicacionMementoMensaje.GetMessage());
        
        var notasAdicionales = new NotasAdicionales();
        Console.WriteLine(notasAdicionales.GetMessage());
    }

    Console.WriteLine();
    Console.WriteLine("Fin del patrón Memento.");
}