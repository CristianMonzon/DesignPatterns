namespace ChainOfResponsability
{
    public class ValidarUsuarioHandler : MensajeHandlerBase
    {
        public override string Handle(MensajeContexto contexto)
        {
            if (string.IsNullOrWhiteSpace(contexto.Usuario))
                return "Error: Usuario inválido.";

            return base.Handle(contexto);
        }
    }
    public class ValidarFechaHandler : MensajeHandlerBase
    {
        public override string Handle(MensajeContexto contexto)
        {
            if (contexto.Fecha > DateTime.Now)
                return "Error: La fecha no puede ser futura.";

            return base.Handle(contexto);
        }
    }
    public class ValidarImportanciaHandler : MensajeHandlerBase
    {
        public override string Handle(MensajeContexto contexto)
        {
            if (contexto.Importancia < 1 || contexto.Importancia > 3)
                return "Error: Importancia fuera de rango (1-3).";

            return base.Handle(contexto);
        }
    }
    public class GenerarMensajeHandler : MensajeHandlerBase
    {
        public override string Handle(MensajeContexto contexto)
        {
            return $"Bienvenido {contexto.Usuario}, mensaje generado correctamente.";
        }
    }
}