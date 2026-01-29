namespace TemplateMethod
{
    // <summary> 
    /// Clave del patrón Template Method: 
    /// La interfaz expone un único método que representa el algoritmo completo. 
    /// La clase base fija la estructura del algoritmo y las subclases solo personalizan pasos específicos. 
    /// El cliente nunca elige el algoritmo, solo invoca el método plantilla. 
    /// </summary>
    public interface IMensajeTemplate
    {
        string GenerarMensaje(string nombre);
    }

    /// <summary>
    /// Clase base del patrón Template Method.
    /// Define el esqueleto del algoritmo para generar un mensaje de bienvenida.
    /// Las subclases implementan los pasos específicos.
    /// </summary>
    public abstract class MensajeBienvenidaTemplate : IMensajeTemplate
    {
        public string GenerarMensaje(string nombre)
        {
            var partesDelMensaje = new List<string> {
                ObtenerSaludoInicial(),
                ObtenerCuerpoMensaje(nombre),
                ObtenerDespedida(),
                ObtenerMensajeOpcional()
            };

            return string.Join(Environment.NewLine,partesDelMensaje.Where(p => !string.IsNullOrWhiteSpace(p)));
        }
        protected abstract string ObtenerSaludoInicial();
        protected abstract string ObtenerCuerpoMensaje(string nombre);
        protected virtual string ObtenerDespedida()
        {
            return "Saludos.";
        }
        protected virtual string ObtenerMensajeOpcional()
        {
            return string.Empty;
        }
    }

    public sealed class MensajeBienvenidaFormal : MensajeBienvenidaTemplate
    {
        protected override string ObtenerSaludoInicial()
        {
            return "Estimado usuario,";
        }

        protected override string ObtenerCuerpoMensaje(string nombre)
        {
            return $"le damos la bienvenida al sistema, {nombre}.";
        }

        protected override string ObtenerDespedida()
        {
            return base.ObtenerDespedida().ToString();
        }

        protected override string ObtenerMensajeOpcional()
        {
            return "PD: Para más información contacte con nuestro equipo técnico";
        }
    }

    public sealed class MensajeBienvenidaInformal : MensajeBienvenidaTemplate
    {
        protected override string ObtenerSaludoInicial()
        {
            return "¡Hey!";
        }
        protected override string ObtenerCuerpoMensaje(string nombre)
        {
            return $"!Qué bueno verte por aquí, {nombre}!";
        }
        protected override string ObtenerDespedida()
        {
            return "Nos vemos.";
        }
        protected override string ObtenerMensajeOpcional()
        {
            return "PD: Si tienes dudas enviame un WhatsApp";
        }
    }
}