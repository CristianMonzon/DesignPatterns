using static Flyweight.MensajeDeBienvenidaFlyweight;

namespace Flyweight
{
    public class MensajeDeBienvenidaFlyweight : IMensajeDeBienvenida
    {
        public enum ImportanciaNivel
        {
            Baja = 1,
            Media = 2,
            Alta = 3
        }

        private readonly MensajeFlyweight _flyweight;
        private readonly string _usuario;
        private readonly DateTime _fecha;
        private readonly ImportanciaNivel _importancia;

        public MensajeDeBienvenidaFlyweight(MensajeFlyweight flyweight,
                                            string usuario,
                                            DateTime fecha,
                                            ImportanciaNivel importancia)
        {
            _flyweight = flyweight;
            _usuario = usuario;
            _fecha = fecha;
            _importancia = importancia;
        }

        public string GetMessage()
        {
            return _flyweight.GenerarMensaje(_usuario, _fecha, _importancia);
        }
    }

    public class MensajeFlyweightFactory
    {
        private readonly Dictionary<string, MensajeFlyweight> _flyweights = new();

        /// <summary>
        /// Otra clave del patrón Flyweight: reutilización de objetos compartidos.
        /// - Se crea una sola vez
        /// - Se reutiliza
        /// - Es inmutable
        /// - Es compartido
        /// </summary>
        /// <param name="plantilla">The plantilla.</param>
        /// <returns></returns>
        public MensajeFlyweight GetFlyweight(string plantilla)
        {
            if (!_flyweights.ContainsKey(plantilla))
            {
                _flyweights[plantilla] = new MensajeFlyweight(plantilla);
            }

            return _flyweights[plantilla];
        }
    }

    /// <summary>
    /// Mensaje Flyweight que contiene la plantilla compartida.
    /// </summary>
    public class MensajeFlyweight
    {
        public string Plantilla { get; }

        public MensajeFlyweight(string plantilla)
        {
            Plantilla = plantilla;
        }

        public string GenerarMensaje(string usuario, DateTime fecha, ImportanciaNivel importancia)
        {
            {
                string importanciaTexto;
                switch (importancia)
                {
                    case ImportanciaNivel.Baja:
                        importanciaTexto = "Baja";
                        break;
                    case ImportanciaNivel.Media:
                        importanciaTexto = "Media";
                        break;
                    case ImportanciaNivel.Alta:
                        importanciaTexto = "Alta";
                        break;
                    default:
                        importanciaTexto = "desconocida";
                        break;
                }

                return Plantilla
                .Replace("{usuario}", usuario)
                .Replace("{fecha}", fecha.ToString())
                .Replace("{importancia}", importanciaTexto);
            }
        }
    }
}