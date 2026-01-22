// See https://aka.ms/new-console-template for more information
using Builder;
Console.WriteLine("Builder → Quiero construir un objeto complejo paso a paso");
Console.WriteLine("Principios que satisface el patrón Builder:");
Console.WriteLine("Separar la construcción del objeto de su representación final.");
Console.WriteLine("Construir un objeto complejo paso a paso.");
Console.WriteLine("Permitir diferentes configuraciones del mismo objeto sin usar constructores gigantes.");
Console.WriteLine();

var builder = new MensajeBuilder(); 
var director = new MensajeDirector();
MensajeCompleto mensajeA = director.ConstruirMensajeUsuarioA(builder);
Console.WriteLine(mensajeA.ToString());
Console.WriteLine();

var explicacion = new ExplicacionBuilderMensaje();
Console.WriteLine(explicacion.GetMessage());

Console.WriteLine("Fin del patrón Builder.");

public class MensajeDirector
{
    public MensajeCompleto ConstruirMensajeUsuarioA(IMensajeBuilder builder)
    {
        IMensajeBuilder mensajeBuilder = new MensajeBuilder();
        mensajeBuilder.ConBienvenida("Bienvenido usuario tipo A");
        mensajeBuilder.ConDespedida("Adiós usuario tipo A");
        mensajeBuilder.ConNotas("Notas usuario tipo A");
        mensajeBuilder.ConError("Error para usuario tipo A");
        return mensajeBuilder.Build();
    }
}

