namespace Bridge
{
    /// <summary>
    /// la clave del patrón Bridge es que las abstracciones heredan de una clase base común
    /// define qué es un mensaje contiene la referencia a la implementación(IFormatoMensaje) establece el “puente” entre abstracción e implementación
    /// </summary>
    /// <seealso cref="Bridge.IMensajeDeBienvenida" />
    public abstract class MensajeBridge : IMensajeDeBienvenida
    {
        protected readonly IFormatoMensaje _formato;

        protected MensajeBridge(IFormatoMensaje formato)
        {
            _formato = formato;
        }

        public abstract string GetMessage();
    }
}
