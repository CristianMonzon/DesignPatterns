namespace Observer
{
    public class ExplicacionObserverMensaje : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "El patrón Observer permite que un objeto (Subject) notifique automáticamente a múltiples observadores " +
                "cuando su estado cambia.\n" +
                "- En este ejemplo, la ColeccionDeMensajesDeBienvenida actúa como Subject.\n" +
                "- Cada vez que se agrega un mensaje, la colección notifica a todos los observadores suscritos.\n" +
                "- Los observadores reaccionan de forma independiente: pueden registrar, auditar, contar o transformar el mensaje.\n" +
                "- El Subject no conoce los detalles de cada observador, lo que reduce el acoplamiento y facilita la extensión del sistema.\n";
        }
    }
}
