namespace Bridge
{
    public interface IFormatoMensaje
    {
        string Formatear(string texto);
    }

    public class FormatoMayusculas : IFormatoMensaje
    {
        public string Formatear(string texto)
        {
            return texto.ToUpper();
        }
    }

    public class FormatoConPrefijo : IFormatoMensaje
    {
        public string Formatear(string texto)
        {
            return $"[INFO] {texto}";
        }
    }
}