namespace Interpreter
{
    public class NotasAdicionales : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Notas adicionales sobre Interpreter:\n" +
                "- Permite representar reglas como objetos reutilizables.\n" +
                "- Facilita crear mini-lenguajes internos (DSL).\n" +
                "- Las expresiones terminales representan reglas simples.\n" +
                "- Las expresiones no terminales combinan reglas para formar expresiones complejas.\n" +
                "- Es ideal para validaciones, filtros y motores de reglas.\n";
        }
    }
}
