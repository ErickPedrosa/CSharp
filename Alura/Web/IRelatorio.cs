namespace Web
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}