using Adapter;

/// <summary>
/// Clase envolvente que adapta la interfaz IServiciosMensaje a IMensajeDeBienvenida.
/// Esta clase es propia de nuestro sistema y permite que los servicios externos puedan ser utilizados
/// </summary>
public class MensajeExternoAdapter : IMensajeDeBienvenida
{
    private readonly IServiciosMensajeExterno _servicioExterno;

    public MensajeExternoAdapter(IServiciosMensajeExterno servicioExterno)
    {
        _servicioExterno = servicioExterno;
    }

    public string GetMessage()
    {
        return _servicioExterno.EscribirMensaje();
    }
}
