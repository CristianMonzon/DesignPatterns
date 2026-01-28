namespace Mediator
{
    public class ExplicacionMediatorMensaje : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "El patrón Mediator centraliza la comunicación entre componentes.\n" +
                "- En este ejemplo, RegistroDeUsuarios no conoce a ValidadorDeUsuario ni al GeneradorDeMensajes, ni al NotificadorDeUsuarios.\n" +
                "- Cada componente notifica eventos al Mediator, y este decide qué otros componentes deben reaccionar. " +
                "- Esto reduce el acoplamiento, mejora la mantenibilidad y permite extender el flujo sin modificar los componentes existentes.\n" +
                "- El Mediator actúa como un 'centro de coordinación' del proceso de bienvenida, garantizando un flujo claro y controlado.";
        }
    }
}
