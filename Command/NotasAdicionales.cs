namespace Command
{
    public class NotasAdicionales : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Notas adicionales sobre Command:\n" +
                "- Un comando es una clase que implementa la interfaz ICommand y representa una acción concreta.\n" +
                "- El invocador solo conoce ICommand, lo que permite ejecutar cualquier comando sin acoplarse a su implementación.\n" +
                "- El receptor contiene la lógica real de la operación y es invocado por el comando.\n" +
                "- Encapsular la acción en un objeto permite almacenar, encolar, deshacer o combinar comandos.\n" +
                "- El patrón facilita la extensión del sistema añadiendo nuevos comandos sin modificar el código existente.\n";
        }
    }
}
