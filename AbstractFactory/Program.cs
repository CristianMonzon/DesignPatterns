using AbstractFactory;

Console.WriteLine("Abstract Factory → Quiero crear familias completas de objetos.");

var factoryA = new UsuarioAFactory();
MostrarMensajes(factoryA);

var factoryB = new UsuarioBFactory();
MostrarMensajes(factoryB);

var ExplicacionAbstractFactoryMethod = new ExplicacionAbstractFactoryMethod();
Console.WriteLine(ExplicacionAbstractFactoryMethod.mensajeDeBienvenida.GetMessage());

Console.WriteLine();
Console.WriteLine("Fin del patrón Abstract Factory.");


void MostrarMensajes(IUsuarioFactory factory)
{
    Console.WriteLine(factory.CrearMensajeBienvenida().GetMessage());
    Console.WriteLine(factory.CrearMensajeDespedida().GetMessage());
    Console.WriteLine(factory.CrearMensajeError().GetMessage());
    Console.WriteLine();
    Console.WriteLine();
}
