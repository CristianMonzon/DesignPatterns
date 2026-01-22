using Builder;
public class MensajeBuilder : IMensajeBuilder
{
    private readonly MensajeCompleto _mensaje;

    public MensajeBuilder()
    {
        _mensaje = new MensajeCompleto();
    }

    public MensajeCompleto Build()
    {
        return _mensaje;
    }

    public IMensajeBuilder ConBienvenida(string bienvenida)
    {
        _mensaje.Bienvenida = bienvenida;
        return this;
    }

    public IMensajeBuilder ConDespedida(string despedida)
    {
        _mensaje.Despedida = despedida;
        return this;
    }

    public IMensajeBuilder ConError(string error)
    {
        _mensaje.Error = error;
        return this;
    }

    public IMensajeBuilder ConNotas(string notas)
    {
        _mensaje.Notas = notas;
        return this;
    }


}