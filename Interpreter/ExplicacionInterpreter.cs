namespace Interpreter
{
    public class ExplicacionInterpreter : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Este ejemplo implementa el patrón Interpreter porque:\n" +
                "- Se define una gramática mediante expresiones que implementan una interfaz común.\n" +
                "- Cada expresión sabe cómo interpretarse sobre el contexto.\n" +
                "- Las expresiones pueden combinarse para formar reglas más complejas.\n" +
                "- El cliente construye el árbol de expresiones y lo evalúa con Interpretar().\n";
        }
    }
}
