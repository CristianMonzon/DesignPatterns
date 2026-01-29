namespace Visitor
{
    public class BonusMensaje : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Comparativa Visitor vs Strategy vs State vs Template Method:\n" +
                "Visitor:\n" +
                "- Agrega operaciones nuevas sin modificar los elementos.\n" +
                "- Los elementos aceptan visitantes (doble despacho).\n" +
                "- Ideal cuando la jerarquía es estable y las operaciones cambian.\n" +
                "Strategy:\n" +
                "- El cliente elige el algoritmo.\n" +
                "- Ideal para políticas o cálculos intercambiables.\n" +
                "State:\n" +
                "- El comportamiento depende del estado interno.\n" +
                "- Ideal para ciclos de vida o máquinas de estados.\n" +
                "Template Method:\n" +
                "- La clase base fija el algoritmo.\n" +
                "- Las subclases redefinen pasos concretos.\n";
        }
    }
}
