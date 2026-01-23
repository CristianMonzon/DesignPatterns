// See https://aka.ms/new-console-template for more information
using Adapter;

Console.WriteLine("Adapter → Permite que clases con interfaces incompatibles puedan trabajar juntas sin modificarlas.");
Console.WriteLine("El Adapter actúa como un traductor entre lo que el sistema espera y lo que una clase externa ofrece.");
Console.WriteLine("Este patrón permite que clases con interfases incompatibles puedan relacionarse.");
Console.WriteLine();

{
    IServiciosMensajeExterno servicioExterno = new ServiciosExternoA();
    string mensaje = servicioExterno.EscribirMensaje();
    Console.WriteLine("Mensaje sin adapter para A");
    Console.WriteLine(mensaje);
}

{
    IServiciosMensajeExterno servicioExterno = new ServiciosExternoB();
    string mensaje = servicioExterno.EscribirMensaje();
    Console.WriteLine("Mensaje sin adapter para B");
    Console.WriteLine(mensaje);
}

{
    IServiciosMensajeExterno servicioExterno = new ServiciosExternoC();
    string mensaje = servicioExterno.EscribirMensaje();
    Console.WriteLine("Mensaje sin adapter para C");
    Console.WriteLine(mensaje);
}

Console.WriteLine();
Console.WriteLine("Si el servicio externo nos cambia la interface IServiciosMensajeExterno nos obliga a refactorizar");
Console.WriteLine("Aqui es cuando viene en nuestra ayuda Adapater. Solo tendriamos que refactorizar MensajeExternoAdapter");
Console.WriteLine();

{
    IServiciosMensajeExterno servicioExterno = new ServiciosExternoA();
    IMensajeDeBienvenida mensajeAdaptado = new MensajeExternoAdapter(servicioExterno);
    string mensajeDeBienvenida = mensajeAdaptado.GetMessage();
    Console.WriteLine("Mensaje adaptado para A");
    Console.WriteLine(mensajeDeBienvenida);
}

{
    IServiciosMensajeExterno servicioExterno = new ServiciosExternoB();
    IMensajeDeBienvenida mensajeAdaptado = new MensajeExternoAdapter(servicioExterno);
    string mensajeDeBienvenida = mensajeAdaptado.GetMessage();
    Console.WriteLine("Mensaje adaptado para B");
    Console.WriteLine(mensajeDeBienvenida);
}

{
    IServiciosMensajeExterno servicioExterno = new ServiciosExternoC();
    IMensajeDeBienvenida mensajeAdaptado = new MensajeExternoAdapter(servicioExterno);
    string mensajeDeBienvenida = mensajeAdaptado.GetMessage();
    Console.WriteLine("Mensaje adaptado para C");
    Console.WriteLine(mensajeDeBienvenida);
}

Console.WriteLine();

{
    var explicacion = new ExplicacionAdapterMensaje();
    Console.WriteLine(explicacion.GetMessage());
}

Console.WriteLine();

Console.WriteLine("Fin del patrón Adapter.");
