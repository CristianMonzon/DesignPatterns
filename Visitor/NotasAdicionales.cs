namespace Visitor
{
    public class NotasAdicionalesVisitorMensaje : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Notas adicionales sobre Visitor:\n" +
                "- Los elementos representan datos; los visitantes representan operaciones.\n" +
                "- Cada elemento implementa Aceptar(IVisitante), que activa el doble despacho.\n" +
                "- Agregar una operación nueva implica crear un visitante nuevo, sin tocar los elementos.\n" +
                "- Ideal cuando la jerarquía de elementos es estable, pero las operaciones cambian.\n" +
                "- El visitante conoce todos los tipos concretos; los elementos no conocen a los visitantes.\n";
        }
    }
}
