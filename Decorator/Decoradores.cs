namespace Decorator
{
    /// <summary>
    /// Esta es la clave del patrón Decorator.
    /// Todas las clases decoradoras deben heredar de esta clase abstracta
    /// </summary>
    /// <seealso cref="Decorator.IMensajeDeBienvenida" />
    public abstract class MensajeDecorador : IMensajeDeBienvenida
    {
        /// <summary>
        /// Todos los decoradores envuelven un mensaje de bienvenida
        /// </summary>
        protected readonly IMensajeDeBienvenida _mensaje;

        protected MensajeDecorador(IMensajeDeBienvenida mensaje)
        {
            _mensaje = mensaje;
        }

        public abstract string GetMessage();
    }

    public class DecoradorConPrefijo : MensajeDecorador
    {
        public DecoradorConPrefijo(IMensajeDeBienvenida mensaje) : base(mensaje) { }

        public override string GetMessage()
        {
            return "[INFO] " + _mensaje.GetMessage();
        }
    }

    public class DecoradorConFecha : MensajeDecorador
    {
        public DecoradorConFecha(IMensajeDeBienvenida mensaje) : base(mensaje) { }

        public override string GetMessage()
        {
            return $"{DateTime.Now:yyyy-MM-dd} - {_mensaje.GetMessage()}";
        }
    }

    public class DecoradorMayusculas : MensajeDecorador
    {
        public DecoradorMayusculas(IMensajeDeBienvenida mensaje) : base(mensaje) { }

        public override string GetMessage()
        {
            return _mensaje.GetMessage().ToUpper();
        }
    }
}