namespace State
{
    public class ExplicacionStateMensaje : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "El patrón State permite que un objeto cambie su comportamiento según su estado interno.\n" +
                "En lugar de usar condicionales, cada estado encapsula su propia lógica.\n" +
                "En este ejemplo, un mensaje de bienvenida puede estar en distintos estados\n" +
                "(Inicial, EnProceso, Finalizado o Error), y el comportamiento cambia dinámicamente según el estado actual del mensaje.\n";
        }
    }
}
