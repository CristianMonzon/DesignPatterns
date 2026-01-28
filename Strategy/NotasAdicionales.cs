namespace Strategy
{
    public class NotasAdicionales: IMensajeDeBienvenida
    {
        public string GetMessage()
        {
            return
                "Notas adicionales sobre el patrón Strategy:\n" +
                "- Evita condicionales (if/switch) al delegar el comportamiento en estrategias intercambiables.\n" +
                "- Cada estrategia es responsable de su propio algoritmo, lo que mejora la cohesión.\n" +
                "- El contexto puede cambiar de estrategia en tiempo de ejecución.\n" +
                "- Es ideal para algoritmos que pueden variar: cálculos, validaciones, formatos, filtros o políticas.\n" +
                "- A diferencia de State, Strategy no representa estados internos, sino algoritmos alternativos.\n";
        }
    }
}
