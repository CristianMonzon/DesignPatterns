using Composite;
public class MensajeCompuesto : IMensajeDeBienvenida
{
    private readonly List<IMensajeDeBienvenida> _mensajes = new();

    public void Add(IMensajeDeBienvenida mensaje)
    {
        _mensajes.Add(mensaje);
    }

    public string GetMessage()
    {
        return string.Join("\n", _mensajes.Select(m => m.GetMessage()));
    }
}
