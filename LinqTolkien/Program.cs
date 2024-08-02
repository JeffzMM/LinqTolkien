using LinqTolkien.Core.Entities;
using LinqTolkien.Core.Service;
using LinqTolkien.Data.Repository;

class Program
{
    static void Main()
    {
        var livroRepository = new LivroRepository();
        var resenhaRepository = new ResenhaRepository();

        var livroService = new LivroService(livroRepository);
        var resenhaService = new ResenhaService(resenhaRepository);

        var livros = livroService.GetAllLivros();
        Console.WriteLine("Livros:");
        foreach (var livro in livros)
        {
            Console.WriteLine($"ID: {livro.Id}, Título: {livro.Titulo}, Autor: {livro.Autor}");
        }

        var resenhasAgrupadas = resenhaService.GetResenhasAgrupadas();
        Console.WriteLine("\nResenhas Agrupadas:");
        foreach (var item in resenhasAgrupadas)
        {
            Console.WriteLine($"Autor: {item.Autor}, Filme: {item.Filme}, Quantidade de Resenhas: {item.QuantidadeDeResenhas}, Avaliação Média: {item.AvaliacaoMedia:F1}, Avaliação Total: {item.AvaliacaoTotal}");
        }
    }
}





