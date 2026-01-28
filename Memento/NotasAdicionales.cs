namespace Memento
{
    public class NotasAdicionales: IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Notas adicionales sobre el patrón Memento:\n" +                
                "- No es un Builder: no construye objetos nuevos, solo captura el estado actual.\n" +
                "- El Originator es el único que conoce la estructura interna del estado que se guarda.\n" +
                "- El Caretaker almacena mementos sin saber qué contienen ni cómo se usan.\n" +
                "- El cliente decide cuándo guardar un estado y cuándo deshacer, coordinando Originator y Caretaker.\n" +
                "- Es importante capturar el estado antes de realizar cambios significativos.\n" +
                "- Redo puede implementarse como extensión usando dos pilas, aunque no forma parte del núcleo del patrón.\n" +
                "- Mantiene la encapsulación: el estado interno no se expone directamente.\n" +
                "- También puede implementarse una variante genérica (Memento<T> y Historial<T>) para reutilizar el patrón con distintos tipos de estado.\n";
        }
    }
}
