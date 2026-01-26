namespace Proxy
{
    public class NotasAdicionales : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Notas adicionales sobre Proxy:\n" +
                "- El Proxy implementa la misma interfaz que el objeto real para que el cliente pueda usarlo de forma transparente.\n" +
                "- Gracias a esto, el cliente no necesita saber si está llamando al objeto real o al Proxy.\n" +
                "- En este ejemplo, la sustitución transparente significa que el Proxy controla el acceso a la operación GetMessage(), pudiendo añadir lógica adicional antes o después de delegar en el objeto real.\n" +
                "- El Proxy decide cuándo crear el objeto real (lazy loading), si registrar logs, validar permisos o aplicar cache.\n" +
                "- El objetivo es añadir comportamiento sin modificar el código del cliente ni la implementación del objeto real.\n" +
                "- Es un patrón de control.\n";

        }
    }
}