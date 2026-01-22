using Prototype;

/// <summary>
/// El objeto MensajeBienvenidaA se clona a si mismo. Es la base del patrón Prototype.
/// </summary>
public class MensajeBienvenidaA : IMensajeDeBienvenida, IPrototype<IMensajeDeBienvenida>
{
    public string Texto { get; set; } = "Bienvenido usuario tipo A";

    public string GetMessage()
    {
        return Texto;
    }

    public IMensajeDeBienvenida Clonar()
    {
        return new MensajeBienvenidaA
        {
            Texto = this.Texto
        };
    }
}
