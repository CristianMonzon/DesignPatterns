namespace Decorator
{
    public class NotasAdicionales : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return "Sin una clase base Decorador tendríamos que repetir el campo mensaje en cada decorador.\n" +
            "Tendríamos que repetir el constructor en cada decorador.\n" +
            "Tendríamos que repetir toda la estructura una y otra vez.\n" +
            "No habría un punto común para extender o añadir nuevos comportamientos.\n" +
            "Sería fácil equivocarse o romper la cadena de decoradores.\n";

        }
    }

}