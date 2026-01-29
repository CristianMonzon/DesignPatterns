namespace ChainOfResponsability
{
    public class ExplicacionChainOfResponsibility : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Este ejemplo implementa Chain of Responsibility porque:\n" +
                "- Cada handler procesa una parte del mensaje o lo delega al siguiente.\n" +
                "- El cliente no sabe cuántos handlers hay ni en qué orden.\n" +
                "- La cadena es flexible: puedes añadir, quitar o reordenar handlers sin tocar el cliente.\n" +
                "- Cada handler tiene una única responsabilidad.\n" +
                "- La petición fluye por la cadena hasta que alguien la maneja.\n";
        }
    }

}
