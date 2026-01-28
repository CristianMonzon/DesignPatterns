namespace Memento
{
    /// <summary>
    /// Originator - Mantiene el estado y sabe guardarlo/restaurarlo.
    /// </summary>
    public class EditorDeMensajes
    {
        private string _texto = string.Empty;

        public MensajeMemento CrearMemento()
        {
            return new MensajeMemento(_texto);
        }

        public void Escribir(string nuevoTexto)
        {
            _texto = nuevoTexto;
            Console.WriteLine($"[Editor] Texto actual: {_texto}");
        }

        public void Restaurar(MensajeMemento memento)
        {
            _texto = memento.Texto;
            Console.WriteLine($"[Editor] Estado restaurado: {_texto}");
        }
    }

    /// <summary>
    /// Memento - Guarda el estado del mensaje
    /// Guarda un "snapshot" inmutable
    /// </summary>
    public class MensajeMemento
    {
        public string Texto { get; }

        public MensajeMemento(string texto)
        {
            Texto = texto;
        }
    }

    /// <summary>
    /// Caretaker - Gestiona los estados sin conocer su contenido.
    /// El formato es LIFO (Last in, First Out)
    /// </summary>
    public class HistorialDeMensajes
    {
        private readonly Stack<MensajeMemento> _estados = new();

        public void Guardar(MensajeMemento memento)
        {
            _estados.Push(memento);
            Console.WriteLine("[Historial] Estado guardado.");
        }

        public MensajeMemento? Deshacer()
        {
            if (_estados.Count == 0)
            {
                Console.WriteLine("[Historial] No hay estados para deshacer.");
                return null;
            }

            var memento = _estados.Pop();
            Console.WriteLine("[Historial] Estado recuperado.");
            return memento;
        }
    }

}
