namespace Proxy
{
    public class MensajeReal : IMensajeDeBienvenida
    {
        private readonly string _usuario;

        public MensajeReal(string usuario)
        {
            // Simula un recurso costoso
            Thread.Sleep(500);
            _usuario = usuario;
        }

        public string GetMessage()
        {
            return $"Bienvenido {_usuario}, este mensaje fue generado por el objeto REAL.";
        }
    }

    /// <summary>
    /// Clase del patrón proxy : MensajeProxy debe implementar la misma interfaz que el Mensaje Real.
    /// </summary>
    public class MensajeProxy : IMensajeDeBienvenida
    {
        private readonly string _usuario;
        private MensajeReal? _mensajeReal;

        public MensajeProxy(string usuario)
        {
            _usuario = usuario;
        }

        /// <summary>
        /// Aqui intercepto el mensaje Real pero MensajeProxy debe poder crear el MensajeReal cuando no hay usuario.
        /// </summary>        
        public string GetMessage()
        {
            if (string.IsNullOrWhiteSpace(_usuario))
                return "[Proxy] No se puede generar el mensaje: usuario inválido.";

            // Lazy loading: solo crea el objeto real cuando se necesita
            if (_mensajeReal == null)
            {
                Console.WriteLine("[Proxy] Creando MensajeReal...");
                _mensajeReal = new MensajeReal(_usuario);
            }

            return _mensajeReal.GetMessage();
        }
    }
}
