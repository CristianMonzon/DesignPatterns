namespace Interpreter
{
    public class MensajeContexto
    {
        public string Usuario { get; set; } = string.Empty;
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int Importancia { get; set; }
        public bool IsAdmin { get; set; }
    }
}
