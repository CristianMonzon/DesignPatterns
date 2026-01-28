namespace Strategy
{
    public interface IStrategySaludo
    {
        /// <summary>
        /// Este es  el "algoritmo" que estoy cambiando
        /// Cada objeto IStrategy implementa un algoritmo diferente
        /// </summary>
        string ObtenerMensaje(string nombre);
    }

    public sealed class SaludoFormal : IStrategySaludo
    {
        public string ObtenerMensaje(string nombre)
        {
            return $"Buenos días, {nombre}. Es un placer saludarle.";
        }
    }

    public sealed class SaludoInformal : IStrategySaludo
    {
        public string ObtenerMensaje(string nombre)
        {
            return $"¡Hey {nombre}! ¿Qué tal?";
        }
    }

    public sealed class SaludoNavidad : IStrategySaludo
    {
        public string ObtenerMensaje(string nombre)
        {
            return $"¡Feliz Navidad, {nombre}!";
        }
    }
}
