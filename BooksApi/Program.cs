using BooksApi.Contexto;
using BooksApi.Entidade;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

// 1. Configura o Banco de Dados em Memória
builder.Services.AddDbContext<LivroDb>(opt => opt.UseInMemoryDatabase("Biblioteca"));
builder.Services.AddOpenApi();


var app = builder.Build();

if (app.Environment.IsDevelopment()) { app.MapOpenApi(); }

// --- ENDPOINTS DO CRUD ---

// GET: Listar todos
app.MapGet("/livros", async (LivroDb db) =>
    await db.Livros.ToListAsync());

// GET: Buscar por ID
app.MapGet("/livros/{id}", async (int id, LivroDb db) =>
    await db.Livros.FindAsync(id) is Livro livro ? Results.Ok(livro) : Results.NotFound());

// POST: Criar novo
app.MapPost("/livros", async (Livro livro, LivroDb db) => {
    db.Livros.Add(livro);
    await db.SaveChangesAsync();
    return Results.Created($"/livros/{livro.Id}", livro);
});

// PUT: Atualizar
app.MapPut("/livros/{id}", async (int id, Livro livroAlterado, LivroDb db) => {
    var livro = await db.Livros.FindAsync(id);
    if (livro is null) return Results.NotFound();

    // No .NET 10, a atualização de records pode ser feita com 'with'
    db.Entry(livro).CurrentValues.SetValues(livroAlterado);
    await db.SaveChangesAsync();
    return Results.NoContent();
});

// DELETE: Remover
app.MapDelete("/livros/{id}", async (int id, LivroDb db) => {
    if (await db.Livros.FindAsync(id) is Livro livro)
    {
        db.Livros.Remove(livro);
        await db.SaveChangesAsync();
        return Results.NoContent();
    }
    return Results.NotFound();
});

app.Run();

// O "Cérebro" da Serialização: Adicione aqui tudo que a API for retornar
[JsonSerializable(typeof(Livro))]
[JsonSerializable(typeof(List<Livro>))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{

}
