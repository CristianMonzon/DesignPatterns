using Flyweight;
using System;

Console.WriteLine("Patrón Flyweight -> Optimiza memoria compartiendo objetos intrínsecos.");
Console.WriteLine();

{
    var factory = new MensajeFlyweightFactory();

    //Creo el flyweight con la plantilla
    string plantilla = "Hola {usuario}, tu acceso fue registrado el {fecha}. Importancia: {importancia}";
    MensajeFlyweight flyweight = factory.GetFlyweight(plantilla);

    var random = new Random();

    //Creo 10 mensajes de bienvenida con la misma plantilla pero con datos extrínsecos diferentes
    for (int indice = 0; indice < 10; indice++)
    {
        var importanciaRandom = (MensajeDeBienvenidaFlyweight.ImportanciaNivel)random.Next(1, 4);
        var fechaRandom = DateTime.Now.AddDays(-random.Next(0, 30)).AddHours(random.Next(0, 24)).AddMinutes(random.Next(0, 60)).AddSeconds(random.Next(0, 60)); 
        var mensaje = new MensajeDeBienvenidaFlyweight(flyweight, $"Usuario_{indice}", fechaRandom, importanciaRandom);
        Console.WriteLine(mensaje.GetMessage());
    }
}
Console.WriteLine();
{
    var explicacion = new ExplicacionFlyweightMensaje();
    Console.WriteLine(explicacion.GetMessage());
}
{ 
    var notasAdicionales = new NotasAdicionales();
    Console.WriteLine(notasAdicionales.GetMessage());
}

Console.WriteLine("Fin del patrón Flyweight.");
