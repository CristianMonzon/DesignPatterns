namespace TemplateMethod
{
    public class ComparativaPatrones : IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Comparativa Template Method vs Strategy vs State:\n" +
                
                "Template Method:\n" +
                "- El algoritmo es fijo.\n" +
                "- Las subclases redefinen pasos concretos.\n" +
                "- Ideal para procesos con estructura común.\n" +
                
                "Strategy:\n" +
                "- El algoritmo completo es intercambiable.\n" +
                "- El cliente elige la estrategia.\n" +
                "- Ideal para políticas, cálculos o formatos.\n" +
                "\n" +
                "State:\n" +
                "- El comportamiento depende del estado interno.\n" +
                "- El estado puede cambiar automáticamente.\n" +
                "- Ideal para ciclos de vida o máquinas de estados.\n";
        }
    }
}
