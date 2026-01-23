using Composite;

public class MensajeSimple : IMensajeDeBienvenida
{
    private readonly string _texto;

    public MensajeSimple(string texto)
    {
        _texto = texto;
    }

    public string GetMessage()
    {
        return _texto;
    }
}
