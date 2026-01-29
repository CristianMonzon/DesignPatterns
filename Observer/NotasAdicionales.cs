using System.Diagnostics;

namespace Observer
{
    public class NotasAdicionales : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return "Notas adicionales sobre el patrón Observer:\n" +
                "- Es útil cuando varios componentes deben reaccionar a un mismo evento sin depender entre ellos.\n" +
                "- El Subject solo sabe que tiene observadores, pero no qué hacen ni cómo procesan el mensaje.\n" +
                "- Los observadores pueden añadirse o quitarse dinámicamente sin modificar el Subject.\n" +
                "- Los observadores son independientes entre sí: cada uno procesa el mensaje según su propia responsabilidad.\n" +
                "- Es un patrón ideal para sistemas de notificaciones, eventos, logs o monitoreo.\n" +
                "- También puede implementarse una variante genérica (Subject<T>) para reutilizar el patrón con distintos tipos de eventos.\n";
        }
    }
}
