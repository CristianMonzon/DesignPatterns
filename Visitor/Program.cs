using Visitor;

Console.WriteLine("Patrón Visitor -> agregar operaciones sin modificar los elementos.");
Console.WriteLine();

IElementoMensaje mensajeBienvenidaFormal = new Mensajes();
IElementoMensaje mensajeBienvenidaInformal = new MensajeBienvenidaInformal();
IElementoMensaje mensajeBienvenidaNavidad = new MensajeBienvenidaNavidad();

var elementos = new List<IElementoMensaje>
{
    mensajeBienvenidaFormal,
    mensajeBienvenidaInformal,
    mensajeBienvenidaNavidad
};

IVisitanteMensaje visitanteImprimir = new VisitanteImprimir();
IVisitanteMensaje visitanteContar = new VisitanteContarCaracteres();

Console.WriteLine("== Visitor imprimir mensajes ==");
foreach (var elemento in elementos)
{
    elemento.Aceptar(visitanteImprimir);
}
Console.WriteLine();

Console.WriteLine("== Visitor contar caracteres ==");
foreach (var elemento in elementos)
{
    elemento.Aceptar(visitanteContar);
}
Console.WriteLine();

var explicacion = new ExplicacionVisitorMensaje();
Console.WriteLine(explicacion.GetMessage());

var notas = new NotasAdicionalesVisitorMensaje();
Console.WriteLine(notas.GetMessage());

var bonus = new BonusMensaje();
Console.WriteLine(bonus.GetMessage());

Console.WriteLine("Fin del patrón Visitor.");




 

namespace Visitor
{
    
}