// See https://aka.ms/new-console-template for more information
using Factory;

Console.WriteLine("Factory Method → Quiero que las subclases decidan qué objeto crear.");

{
    var usuarioA = new UsuarioA();
    IMensajeDeBienvenida mensajeDeBienvenida = usuarioA.CrearMensaje();
    Console.WriteLine(mensajeDeBienvenida.GetMessage());
}
{
    var usuarioB = new UsuarioB();
    IMensajeDeBienvenida mensajeDeBienvenida = usuarioB.CrearMensaje();
    Console.WriteLine(mensajeDeBienvenida.GetMessage());
}

{
    var usuarioC = new UsuarioC();
    IMensajeDeBienvenida mensajeDeBienvenida = usuarioC.CrearMensaje();
    Console.WriteLine(mensajeDeBienvenida);     //No recomendable pero valido dado mensajeDeBienvenida que sobrrescribe ToString();
}

Console.WriteLine();
{
    var explicacionFactoryMethod = new ExplicacionFactoryMethod();
    var mensaje= explicacionFactoryMethod.mensajeDeBienvenida.GetMessage();
    Console.WriteLine(mensaje);
}

Console.WriteLine();
{
    var notasAdicionales = new NotasAdicionales();
    var mensaje = notasAdicionales.mensajeDeBienvenida.GetMessage();
    Console.WriteLine(mensaje);
}

Console.WriteLine();
Console.WriteLine("Fin del patrón Factory.");