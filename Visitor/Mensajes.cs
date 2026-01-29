namespace Visitor
{
    public interface IElementoMensaje
    {
        /// <summary>
        /// Clave del patrón. Se inyecta una interfase visitante que contiene métodos con los tres mensajes de bienvenida.
        /// </summary>
        void Aceptar(IVisitanteMensaje visitante);
    }
    public sealed class Mensajes : IElementoMensaje
    {
        public string Texto
        {
            get
            {
                return "Estimado usuario, le damos la bienvenida al sistema.";
            }
        }
        public void Aceptar(IVisitanteMensaje visitante)
        {
            visitante.Visitar(this);
        }
    }

    public sealed class MensajeBienvenidaInformal : IElementoMensaje
    {
        public string Texto
        {
            get
            {
                return "¡Hey! Qué bueno verte por aquí.";
            }
        }
        public void Aceptar(IVisitanteMensaje visitante)
        {
            visitante.Visitar(this);
        }
    }

    public sealed class MensajeBienvenidaNavidad : IElementoMensaje
    {
        public string Texto
        {
            get
            {
                return "¡Felices fiestas y bienvenido al sistema!";
            }
        }

        /// <summary>
        /// Otra clave del patrón. 
        /// Esto es llamado "Doble despacho".
        /// Si es MensajeBienvenidaFormal → llama a Visitar(MensajeBienvenidaFormal)
        /// Si es MensajeBienvenidaInformal → llama a Visitar(MensajeBienvenidaInformal)
        /// Si es MensajeBienvenidaNavidad → llama a Visitar(MensajeBienvenidaNavidad)
        /// </summary>
        public void Aceptar(IVisitanteMensaje visitante)
        {
            visitante.Visitar(this);
        }
    }
}