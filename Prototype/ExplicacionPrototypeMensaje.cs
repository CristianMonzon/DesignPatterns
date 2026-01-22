namespace Prototype
{
    public class ExplicacionPrototypeMensaje : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Este ejemplo implementa el patrón Prototype porque:\n" +
                "- Los objetos (como MensajeCompleto o MensajeBienvenidaA) pueden clonarse sin conocer su clase concreta.\n" +
                "- Cada clase define su propio método Clonar(), lo que permite duplicar objetos con su estado actual.\n" +
                "- El cliente no necesita usar constructores ni depender de la lógica interna de creación.\n" +
                "- Puedes crear variaciones de un mensaje clonando uno existente y modificando solo lo necesario.\n" +
                "- Puedes añadir nuevos tipos de mensajes clonables sin modificar el código existente, cumpliendo OCP.\n";
        }
    }

}
