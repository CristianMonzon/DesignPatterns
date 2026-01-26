namespace Facade
{

    public class BienvenidaFacade
    {
        private readonly ValidadorDeUsuario _validador = new();
        private readonly GeneradorDeTextoDeBienvenida _generador = new();
        private readonly CalculadorDeImportancia _calculador = new();
        private readonly FormateadorDeMensaje _formateador = new();
        private readonly LoggerDeAccesos _logger = new();

        /// <summary>
        /// Esta es la clave del patrón Façade: un método simple que oculta la complejidad del subsistema.
        /// </summary>
        public IMensajeDeBienvenidaFacade CrearBienvenida(string usuario)
        {
            if (!_validador.EsValido(usuario))
                throw new ArgumentException("Usuario inválido");

            var texto = _generador.Generar(usuario);
            var importancia = _calculador.Calcular(usuario);
            var textoFormateado = _formateador.Formatear(texto, importancia);

            _logger.Registrar(usuario);

            return new MensajeDeBienvenida(usuario, textoFormateado, importancia);
        }
    }


    public class MensajeDeBienvenida : IMensajeDeBienvenidaFacade
    {
        public string Usuario { get; }
        public DateTime Fecha { get; }
        public string Texto { get; }
        public int Importancia { get; }

        public MensajeDeBienvenida(string usuario, string texto, int importancia)
        {
            Usuario = usuario;
            Texto = texto;
            Importancia = importancia;
            Fecha = DateTime.Now;
        }

        public string GetMessage()
        {
            return $"[{Fecha}] {Texto} (Importancia: {Importancia})";
        }
    }

    public class ValidadorDeUsuario
    {
        public bool EsValido(string usuario)
        {
            return !string.IsNullOrWhiteSpace(usuario);
        }
    }

    public class GeneradorDeTextoDeBienvenida
    {
        public string Generar(string usuario)
        {
            return $"Hola {usuario}, bienvenido al sistema.";
        }
    }

    public class CalculadorDeImportancia
    {
        public int Calcular(string usuario)
        {
            return usuario.Length % 5 + 1;
        }
    }

    public class FormateadorDeMensaje
    {
        public string Formatear(string texto, int importancia)
        {
            return $"[IMPORTANCIA {importancia}] {texto}";
        }
    }

    public class LoggerDeAccesos
    {
        public void Registrar(string usuario)
        {
            Console.WriteLine($"[LOG] Acceso registrado para {usuario}");
        }
    }

}