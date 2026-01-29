// See https://aka.ms/new-console-template for more information
using Bridge;

Console.WriteLine("Bridge -> Separa la abstracción de su implementación, permitiendo que ambas evolucionen de forma independiente.");
Console.WriteLine();

{
    IFormatoMensaje formatomayusycula = new FormatoMayusculas();
    IMensajeDeBienvenida mensaje = new MensajeBienvenidaA_Bridge(formatomayusycula);
    var formato = mensaje.GetMessage();
    Console.WriteLine(formato);
}
{
    IFormatoMensaje formatoprefijo = new FormatoConPrefijo();
    IMensajeDeBienvenida mensaje = new MensajeBienvenidaA_Bridge(formatoprefijo);
    var formato = mensaje.GetMessage();
    Console.WriteLine(formato);
}
{
    IFormatoMensaje formatomayusycula = new FormatoMayusculas();
    IMensajeDeBienvenida mensaje = new MensajeBienvenidaB_Bridge(formatomayusycula, true);
    var formato = mensaje.GetMessage();
    Console.WriteLine(formato);
}
{
    IFormatoMensaje formatoprefijo = new FormatoConPrefijo();
    IMensajeDeBienvenida mensaje = new MensajeBienvenidaB_Bridge(formatoprefijo, true);
    var formato = mensaje.GetMessage();
    Console.WriteLine(formato);
}

Console.WriteLine("En este ejemplo aparecen 4 usos posibles, pero gracias a Bridge no necesitamos crear 4 clases.");
Console.WriteLine("Podemos generar todas las combinaciones en tiempo de ejecución usando composición.");

Console.WriteLine();

Console.WriteLine("Sin bridge tendriamos clases de este tipo");
Console.WriteLine("MensajeA_Mayusculas");
Console.WriteLine("MensajeA_Prefijo");
Console.WriteLine("MensajeB_Mayusculas");
Console.WriteLine("MensajeB_Prefijo");

Console.WriteLine();
{
    var explicacion = new ExplicacionBridgeMensaje();
    Console.WriteLine(explicacion.GetMessage());

    var notasAdicionales = new NotasAdicionalesBridge();
    Console.WriteLine(notasAdicionales.GetMessage());

}
Console.WriteLine("Fin del patrón Bridge.");

