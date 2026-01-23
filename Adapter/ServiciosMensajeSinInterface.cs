/// <summary>
/// Está es la interfaz que define el contrato para los servicios externos de mensajes.
/// No coincide con la interfaz que el sistema espera (IMensajeDeBienvenida).
/// No podemos controlarlos ya que son servicios de terceros.
/// Por esto, necesitamos un Adapter para que el sistema pueda trabajar con ellos.
/// </summary>
public interface IServiciosMensajeExterno
{
    string EscribirMensaje();
}

public class ServiciosExternoA : IServiciosMensajeExterno
{
    public string EscribirMensaje()
    {
        return "Mensaje generado por el servicio externo A";
    }
}

public class ServiciosExternoB : IServiciosMensajeExterno
{
    public string EscribirMensaje()
    {
        return "Mensaje generado por el servicio externo B";
    }
}


public class ServiciosExternoC : IServiciosMensajeExterno
{
    public string EscribirMensaje()
    {
        return "Mensaje generado por el servicio externo C";
    }
}