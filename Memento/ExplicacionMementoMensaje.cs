namespace Memento
{
    public class ExplicacionMementoMensaje : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "El patrón Memento permite guardar y restaurar el estado interno de un objeto sin violar su encapsulación.\n" +
                "- En este ejemplo, el EditorDeMensajes actúa como Originator y mantiene el estado del texto.\n" +
                "- MensajeMemento captura un snapshot inmutable del estado del editor.\n" +
                "- HistorialDeMensajes funciona como Caretaker, almacenando los snapshots sin conocer su contenido.\n" +
                "- El cliente puede deshacer cambios restaurando estados previos sin exponer la estructura interna del editor.\n" +
                "- Es un patrón ideal para implementar Undo/Redo, versiones o snapshots de objetos.\n";
        }
    }
}
