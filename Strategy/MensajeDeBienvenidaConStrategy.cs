namespace Strategy
{

    /// <summary>
    /// La clave del patrón. Es el contexto del patrón Strategy.
    /// Tiene una referencia a la estrategia que está usando y delega en ella la generación del mensaje de bienvenida.
    /// </summary>
    public class MensajeDeBienvenidaConStrategy
    {
        private IStrategySaludo _strategy;

        public MensajeDeBienvenidaConStrategy(IStrategySaludo strategy)
        {
            _strategy = strategy;
        }

        public void CambiarStrategy(IStrategySaludo nuevaStrategy)
        {
            _strategy = nuevaStrategy;
        }

        public string GetMessage(string nombre)
        {
            return _strategy.ObtenerMensaje(nombre);
        }
    }


}