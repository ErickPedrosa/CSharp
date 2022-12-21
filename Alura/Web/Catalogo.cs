namespace Web
{
    public class Catalogo : ICatalogo
    {
        public List<Livro> GetLivros()
        {
            var livros = new List<Livro>
            {
                new Livro("001", "Quem mexeu na minha Query?", 12.99m),
                new Livro("002", "Fique rico com C#", 30.99m),
                new Livro("003", "Java para baixinhos", 25.99m)
            };

            return livros;
        }
    }
}
