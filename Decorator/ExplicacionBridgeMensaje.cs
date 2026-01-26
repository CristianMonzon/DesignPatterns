namespace Decorator
{
    public class ExplicacionDecoratorMensaje : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Este ejemplo implementa el patrón Decorator porque:\n" +
                "- Permite añadir funcionalidades adicionales a un mensaje sin modificar su clase original.\n" +
                "- MensajeSimple representa el mensaje base.\n" +
                "- Los decoradores (DecoradorMayusculas, DecoradorConPrefijo, DecoradorConFecha) envuelven un mensaje existente.\n" +
                "- Todos implementan IMensajeDeBienvenida, por lo que el cliente los usa de forma uniforme.\n" +
                "- Los decoradores pueden encadenarse dinámicamente para construir comportamientos complejos.\n" +
                "- Esto evita crear múltiples subclases para cada combinación de funcionalidades.\n" +
                "- Decorator cumple OCP: puedes añadir nuevos decoradores sin modificar código existente.\n";
        }
    }
}