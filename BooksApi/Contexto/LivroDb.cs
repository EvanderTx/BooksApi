using BooksApi.Entidade;
using Microsoft.EntityFrameworkCore;

namespace BooksApi.Contexto;

public class LivroDb:DbContext
{
    public LivroDb(DbContextOptions<LivroDb> options): base(options) { }
    
    public DbSet<Livro> Livros => Set<Livro>();

}
