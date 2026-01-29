namespace Iterator
{
    public class ColeccionDeMensajesDeBienvenida : IMensajeColeccion<IMensajeDeBienvenida>
    {
        private readonly List<IMensajeDeBienvenida> _mensajes = new();

        public void Agregar(IMensajeDeBienvenida mensaje)
        {
            _mensajes.Add(mensaje);
        }

        public IMensajeIterator<IMensajeDeBienvenida> CrearIterador()
        {
            return new MensajeIterator(_mensajes);
        }
    }
    public class MensajeIterator : IMensajeIterator<IMensajeDeBienvenida>
    {
        private readonly List<IMensajeDeBienvenida> _mensajes;
        private int _posicion = 0;

        public MensajeIterator(List<IMensajeDeBienvenida> mensajes)
        {
            _mensajes = mensajes;
        }
        public bool HasNext()
        {
            return _posicion < _mensajes.Count;
        }
        public IMensajeDeBienvenida Next()
        {
            return _mensajes[_posicion++];
        }
    }
}
