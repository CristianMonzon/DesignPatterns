namespace Observer
{
    
    public interface IMensajesSubject
    {
        void Suscribir(IObserver observer);
        void Desuscribir(IObserver observer);
    }

    /// <summary>
    /// Subject del patrón Observer que gestiona mensajes y notifica a los observadores.
    /// Clase sealed (sellada a herencias): No queremos que el Subject del patrón Observer pueda alterarse mediante herencia.
    /// </summary>
    public sealed class ColeccionDeMensajesDeBienvenida : IMensajesSubject
    {
        private readonly List<IMensajeDeBienvenida> _mensajes = new List<IMensajeDeBienvenida>();
        private readonly List<IObserver> _observadores = new List<IObserver>();

        /// <summary>
        /// Esta es una clave del patron Observer. 
        /// Al agregar el mensaje se notifica automaticamente.    
        /// </summary>
        /// <param name="mensaje">The mensaje.</param>
        public void Agregar(IMensajeDeBienvenida mensaje)
        {
            _mensajes.Add(mensaje);
            Notificar(mensaje);
        }

        public void Suscribir(IObserver observer)
        {
            _observadores.Add(observer);
        }
        public void Desuscribir(IObserver observer)
        {
            _observadores.Remove(observer);
        }

        /// <summary>
        /// Otra clave del patron.
        /// El metodo de notificación es privado de la coleccion
        /// </summary>
        private void Notificar(IMensajeDeBienvenida mensaje)
        {
            foreach (IObserver observador in _observadores)
                observador.Actualizar(mensaje);
        }
    }

    }
