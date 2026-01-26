namespace Flyweight
{
    public class ExplicacionFlyweightMensaje : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Este ejemplo implementa el patrón Flyweight porque:\n" +
                "- Se reutilizan objetos que contienen información intrínseca (plantillas de mensaje).\n" +
                "- La fábrica garantiza que no se creen Flyweights duplicados.\n" +
                "- La parte extrínseca (usuario, fecha, importancia) se pasa desde fuera.\n" +
                "- Reduce el uso de memoria cuando hay muchos mensajes similares.\n" +
                "- El cliente no conoce la complejidad interna de la reutilización.\n" +
                "- Cumple Single Responsability Principle: la fábrica gestiona la reutilización.\n" +
                "- Cumple Open/Closed Principle: se pueden añadir nuevas plantillas sin modificar código existente.\n" +
                "- Es un patrón de optimización.\n";
        }
    }
}
