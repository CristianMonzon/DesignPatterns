namespace Builder
{
    /// <summary>
    /// La interfaz se usa a sí misma como tipo de retorno.
    /// </summary>
    public interface IMensajeBuilder
    {
        IMensajeBuilder ConBienvenida(string bienvenida);
        IMensajeBuilder ConDespedida(string despedida);
        IMensajeBuilder ConError(string error);
        IMensajeBuilder ConNotas(string notas);
        MensajeCompleto Build();
    }
}
