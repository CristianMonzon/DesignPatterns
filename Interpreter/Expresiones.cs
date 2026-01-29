namespace Interpreter
{
    public interface IExpresion
    {
        bool Interpretar(MensajeContexto contexto);
    }
    public class UsuarioExisteExpression : IExpresion
    {
        public bool Interpretar(MensajeContexto contexto)
        {
            return !string.IsNullOrWhiteSpace(contexto.Usuario);
        }
    }
    public class ImportanciaAltaExpression : IExpresion
    {
        public bool Interpretar(MensajeContexto contexto)
        {
            return contexto.Importancia >= 5;
        }
    }
    public class AndExpression : IExpresion
    {
        private readonly IExpresion _left;
        private readonly IExpresion _right;

        public AndExpression(IExpresion left, IExpresion right)
        {
            _left = left;
            _right = right;
        }

        public bool Interpretar(MensajeContexto contexto)
        {
            return _left.Interpretar(contexto) && _right.Interpretar(contexto);
        }
    }
    public class OrExpression : IExpresion
    {
        private readonly IExpresion _left;
        private readonly IExpresion _right;

        public OrExpression(IExpresion left, IExpresion right)
        {
            _left = left;
            _right = right;
        }

        public bool Interpretar(MensajeContexto contexto)
        {
            return _left.Interpretar(contexto) || _right.Interpretar(contexto);
        }
    }
    public class EsAdminExpression : IExpresion
    {

        public bool Interpretar(MensajeContexto contexto)
        {
            return contexto.IsAdmin;
        }
    }    
}