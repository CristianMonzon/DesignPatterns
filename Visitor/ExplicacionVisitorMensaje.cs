namespace Visitor
{
    /// </summary>
    public class ExplicacionVisitorMensaje : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Patrón Visitor:\n" +
                "Permite agregar operaciones nuevas a una jerarquía de clases sin modificarlas. " +
                "Los elementos aceptan un visitante, y el visitante ejecuta la operación adecuada " +
                "según el tipo concreto del elemento. Esto evita modificar las clases existentes " +
                "cuando se agregan comportamientos nuevos.\n";
        }
    }
}
