namespace Proxy
{
    public class ExplicacionProxyMensaje : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Este ejemplo implementa el patrón Proxy porque:\n" +
                "- El cliente interactúa con IMensajeDeBienvenida sin saber si usa un objeto real o un proxy.\n" +
                "- MensajeProxy controla el acceso al objeto real (MensajeReal).\n" +
                "- El objeto real se crea solo cuando es necesario (lazy loading).\n" +
                "- El proxy puede añadir lógica adicional: logs, permisos, cache, etc.\n" +
                "- El cliente no necesita conocer la existencia del proxy.\n" +
                "- Proxy permite proteger, optimizar o controlar el acceso a objetos costosos.\n";
        }
    }
}
