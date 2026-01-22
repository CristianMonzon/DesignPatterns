namespace AbstractFactory
{
    public class UsuarioAFactory : IUsuarioFactory
    {
        public IMensajeDeBienvenida CrearMensajeBienvenida() => new MensajeBienvenidaA();
        public IMensajeDespedida CrearMensajeDespedida() => new MensajeDespedidaA();
        public IMensajeError CrearMensajeError() => new MensajeErrorA();
    }

    public class UsuarioBFactory : IUsuarioFactory
    {
        public IMensajeDeBienvenida CrearMensajeBienvenida() => new MensajeBienvenidaB();
        public IMensajeDespedida CrearMensajeDespedida() => new MensajeDespedidaB();
        public IMensajeError CrearMensajeError() => new MensajeErrorB();
    }
}