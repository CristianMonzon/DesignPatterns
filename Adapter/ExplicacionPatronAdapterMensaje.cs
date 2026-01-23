using Adapter;
public class ExplicacionAdapterMensaje : IMensajeDeBienvenida
{
    public string GetMessage()
    {
        return
            "Este ejemplo implementa el patrón Adapter porque:\n" +
            "- El sistema espera trabajar con la interfaz IMensajeDeBienvenida.\n" +
            "- Los servicios externos (ServiciosExternoA, B, C...) implementan una interfaz incompatible: IServiciosMensajeExterno.\n" +
            "- No podemos modificar los servicios externos porque son de terceros.\n" +
            "- El Adapter (MensajeExternoAdapter) traduce IServiciosMensajeExterno a IMensajeDeBienvenida.\n" +
            "- Gracias al Adapter, el cliente puede usar cualquier servicio externo sin cambiar su código.\n" +
            "- Se cumple el principio Open/Closed: se pueden añadir nuevos servicios externos sin modificar el sistema.\n" +
            "- Se cumple el principio DIP: el cliente depende de la abstracción IMensajeDeBienvenida, no de clases externas.\n" +
            "- El Adapter encapsula la conversión de EscribirMensaje() a GetMessage(), evitando acoplamiento.\n";
    }
}
