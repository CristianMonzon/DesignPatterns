namespace Bridge
{
    public class MensajeBienvenidaA_Bridge : MensajeBridge
    {
        public MensajeBienvenidaA_Bridge(IFormatoMensaje formato) : base(formato)
        {
        }

        public override string GetMessage()
        {
            return _formato.Formatear("Bienvenido usuario tipo A");
        }
    }

    public class MensajeBienvenidaB_Bridge : MensajeBridge
    {
        private readonly bool _perfilCompleto;

        public MensajeBienvenidaB_Bridge(IFormatoMensaje formato, bool perfilCompleto)
            : base(formato)
        {
            _perfilCompleto = perfilCompleto;
        }

        public override string GetMessage()
        {
            if (!_perfilCompleto)
                return _formato.Formatear("No puedes recibir el mensaje. Completa tu perfil.");

            return _formato.Formatear("Bienvenido usuario tipo B");
        }
    }
}
