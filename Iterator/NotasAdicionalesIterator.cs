namespace Iterator
{
    public class NotasAdicionalesIterator : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Notas adicionales sobre Iterator:\n" +
                "- Separa la lógica de iteración de la colección.\n" +
                "- Permite múltiples iteradores simultáneos sobre la misma colección.\n" +
                "- Facilita cambiar la forma de recorrer sin modificar el cliente.\n" +
                "- Es la base de foreach en muchos lenguajes.\n";
        }
    }

}
