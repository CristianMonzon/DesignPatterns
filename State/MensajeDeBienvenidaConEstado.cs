namespace State
{
    public class MensajeDeBienvenidaConEstado : IMensajeDeBienvenida
    {
        private IEstadoMensaje _estadoActual;

        public MensajeDeBienvenidaConEstado(IEstadoMensaje estadoInicial)
        {
            _estadoActual = estadoInicial;
        }

        public void CambiarEstado(IEstadoMensaje nuevoEstado)
        {
            _estadoActual = nuevoEstado;
        }

        public string GetMessage()
        {
            return _estadoActual.ObtenerMensaje();
        }
    }
}


