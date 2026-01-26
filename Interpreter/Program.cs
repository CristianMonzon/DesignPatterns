using Interpreter;

Console.WriteLine("Patrón Interpreter -> Evaluación de reglas mediante un árbol de expresiones");
{
    var contexto = new MensajeContexto
    {
        Usuario = "Usuario A",
        Importancia = 7,
        IsAdmin = false
    };

    // Expresiones terminales
    IExpresion usuarioExiste = new UsuarioExisteExpression();
    IExpresion importanciaAlta = new ImportanciaAltaExpression();
    IExpresion esAdmin = new EsAdminExpression(); // si el contexto lo soporta

    // Sub-regla: UsuarioExiste AND ImportanciaAlta
    IExpresion reglaBasica = new AndExpression(usuarioExiste, importanciaAlta);

    // Regla completa: (UsuarioExiste AND ImportanciaAlta) OR EsAdmin
    IExpresion reglaCompleta = new OrExpression(reglaBasica, esAdmin);

    // Evaluación
    bool resultado = reglaCompleta.Interpretar(contexto);

    Console.WriteLine("Esquema:");
    Console.WriteLine("               OR");
    Console.WriteLine("             /     \\");
    Console.WriteLine("           AND     EsAdmin");
    Console.WriteLine("         /     \\");
    Console.WriteLine("   Usuario   ImportanciaAlta");
    Console.WriteLine();
    Console.WriteLine($"Resultado de la regla completa: {resultado}");
}
Console.WriteLine();
{
    var explicacionInterpreter = new ExplicacionInterpreter();
    Console.WriteLine(explicacionInterpreter.GetMessage());
}
{
    var notasAdicionales = new NotasAdicionales();
    Console.WriteLine(notasAdicionales.GetMessage());
}

Console.WriteLine("Fin patrón Interpreter");
