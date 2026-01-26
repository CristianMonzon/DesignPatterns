namespace Command
{
    public class ExplicacionCommand : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Este ejemplo implementa el patrón Command porque:\n" +
                "- Cada acción se encapsula en un objeto comando que implementa la interfaz ICommand.\n" +
                "- El comando contiene toda la información necesaria para ejecutar la operación.\n" +
                "- El invocador no conoce los detalles de la lógica, solo sabe ejecutar comandos.\n" +
                "- El receptor es quien realmente realiza el trabajo cuando el comando se ejecuta.\n" +
                "- Se desacopla completamente quién solicita la acción de quién la ejecuta.\n";
        }
    }
}
